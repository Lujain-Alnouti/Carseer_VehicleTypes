var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
// Add services
builder.Services.AddControllers(); //to build RestApi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<VehicleService>();
var app = builder.Build();
app.UseCors("AllowAngular");
// Configure pipeline

    app.UseSwagger();
    app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapControllers();

app.Run();