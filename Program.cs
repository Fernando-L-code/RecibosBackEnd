using Microsoft.EntityFrameworkCore;
using recibosBack.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//dominios externos permitidos, *configurar el domini en caso de cambias la url* 

var proveedor = builder.Services.BuildServiceProvider();
var configuration = proveedor.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{

    var frontEndUrl = configuration.GetValue<string>("front_url");
    options.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins(frontEndUrl).AllowAnyMethod().AllowAnyHeader();

        });

});

builder.Services.AddDbContext<AppDbContext>(options =>
{
        options.UseSqlServer(builder.Configuration.GetConnectionString ("Conexion"));
});

//builder.request.ContentType = "application/json"

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{   
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
