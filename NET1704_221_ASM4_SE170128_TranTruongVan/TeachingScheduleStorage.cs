using System.Collections.Concurrent;
using System.Text.Json;

namespace NET1704_221_ASM4_SE170128_TranTruongVan;

public class TeachingScheduleStorage
{
    private readonly string _filePath;

    public TeachingScheduleStorage()
    {
        _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schedules.json");
        if (!File.Exists(_filePath))
        {
            File.WriteAllText(_filePath, "[]");
        }
    }

    public void InsertSchedules(List<TeachingSchedule> schedules)
    {
        var existingSchedules = GetSchedules().ToList();
        existingSchedules.AddRange(schedules);
        WriteSchedulesToFile(existingSchedules);
    }

    public IEnumerable<TeachingSchedule> GetSchedules()
    {
        var fileContent = File.ReadAllText(_filePath);
        return JsonSerializer.Deserialize<List<TeachingSchedule>>(fileContent)!;
    }

    public void RemoveDeletedSchedules()
    {
        var remainingSchedules = GetSchedules().Where(s => !s.IsDelete).ToList();
        WriteSchedulesToFile(remainingSchedules);
    }

    private void WriteSchedulesToFile(List<TeachingSchedule> schedules)
    {
        var fileContent = JsonSerializer.Serialize(schedules, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, fileContent);
    }
}