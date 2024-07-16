using System.Text.Json;
using Microsoft.Extensions.Hosting.WindowsServices;
using NET1704_221_ASM4_SE170128_TranTruongVan;

var builder = WebApplication.CreateBuilder(args);

if (WindowsServiceHelpers.IsWindowsService())
{
    builder.Host.UseWindowsService();
}

builder.Services.AddSingleton<TeachingScheduleStorage>();
builder.Services.AddHostedService<RemoveDeletedTeachingScheduleWorker>();
builder.Services.AddHttpClient();

var app = builder.Build();

app.MapPost("/schedules", (TeachingSchedule schedule, TeachingScheduleStorage storage) =>
{
    storage.InsertSchedules([schedule]);
    return Results.Ok();
});

await app.RunAsync();