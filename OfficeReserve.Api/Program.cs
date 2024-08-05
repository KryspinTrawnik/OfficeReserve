var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "OfficeReserve",
        Version = "v1",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Kryspin",
            Url = new Uri("https://www.linkedin.com/in/kryspin-trawnik-5143b897/")
        },
        Description = "OfficeReserve is a WebAPI designed to streamline the reservation of offices and meeting rooms within a company's building."
    });
    var filepath = Path.Combine(AppContext.BaseDirectory, "OfficeReserve.Api.xml");
    c.IncludeXmlComments(filepath);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OfficeReserve"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
