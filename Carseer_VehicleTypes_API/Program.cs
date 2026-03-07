var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers(); //to build RestApi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient<VehicleService>();
var app = builder.Build();

// Configure pipeline

    app.UseSwagger();
    app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapControllers();

app.Run();