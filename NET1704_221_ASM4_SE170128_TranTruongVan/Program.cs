using System.Text.Json;
using NET1704_221_ASM4_SE170128_TranTruongVan;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<TeachingScheduleStorage>();
builder.Services.AddHostedService<RemoveDeletedTeachingScheduleWorker>();
builder.Services.AddHttpClient();

var app = builder.Build();

app.MapPost("/schedules", (TeachingSchedule schedule, TeachingScheduleStorage storage) =>
{
    storage.InsertSchedules([schedule]);
    return Results.Ok();
});

var scheduleStorage = app.Services.GetRequiredService<TeachingScheduleStorage>();
scheduleStorage.InsertSchedules(InitialData.Schedules);

await app.RunAsync();