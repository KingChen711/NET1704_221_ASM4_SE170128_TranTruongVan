using System.Text.Json;

namespace NET1704_221_ASM4_SE170128_TranTruongVan;

public class RemoveDeletedTeachingScheduleWorker : BackgroundService
{
    private readonly ILogger<RemoveDeletedTeachingScheduleWorker> _logger;
    private readonly TeachingScheduleStorage _scheduleStorage;

    public RemoveDeletedTeachingScheduleWorker(ILogger<RemoveDeletedTeachingScheduleWorker> logger,
        TeachingScheduleStorage scheduleStorage)
    {
        _logger = logger;
        _scheduleStorage = scheduleStorage;
    }

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            var schedules = _scheduleStorage.GetSchedules();
            var schedulesJson =
                JsonSerializer.Serialize(schedules, new JsonSerializerOptions { WriteIndented = true });
            _logger.LogInformation("Schedules: {schedules}", schedulesJson);

            await Task.Delay(5000, cancellationToken); // Run every 60 seconds

            _scheduleStorage.RemoveDeletedSchedules();
            _logger.LogInformation("Deleted schedules removed at: {time}", DateTimeOffset.Now);

            await Task.Delay(5000, cancellationToken);
        }
    }
}