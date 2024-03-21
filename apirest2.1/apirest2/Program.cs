using Repositories.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); //Importar controladores (inyección de dependencias)
builder.Services.AddSingleton<ProductoRepositorio>(); //singleton instancia una clase durante el tiempo de vida de la app
builder.Services.AddSingleton<PersonaRepositorio>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers(); //método add controllers, desde este punto se comienzan a usar
app.Run();

