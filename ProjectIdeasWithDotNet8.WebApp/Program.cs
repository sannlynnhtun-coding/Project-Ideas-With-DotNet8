using ProjectIdeasWithDotNet8.LatHtaukBayDin;
using ProjectIdeasWithDotNet8.DreamDictionary;
using ProjectIdeasWithDotNet8.Birds;
using ProjectIdeasWithDotNet8.PickAPile;
using ProjectIdeasWithDotNet8.BaganMap;

using ProjectIdeasWithDotNet8.MyanmarMonths;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddLatHtaukBayDinModularService();
builder.Services.AddDreamDictionaryService();
builder.Services.AddBirdsService();
builder.Services.AddPickAPileService();
builder.Services.AddBaganMapModularService();
builder.Services.AddMyanmarMonthsService();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
