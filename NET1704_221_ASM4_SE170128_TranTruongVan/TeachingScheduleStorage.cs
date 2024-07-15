using System.Collections.Concurrent;

namespace NET1704_221_ASM4_SE170128_TranTruongVan;

public class TeachingScheduleStorage
{
    private ConcurrentBag<TeachingSchedule> _schedules = [];

    public void InsertSchedules(List<TeachingSchedule> schedules)
    {
        schedules.ForEach(schedule => _schedules.Add(schedule));
    }

    public IEnumerable<TeachingSchedule> GetSchedules()
    {
        return _schedules;
    }

    public void RemoveDeletedSchedules()
    {
        var remainingSchedules = _schedules.Where(s => !s.IsDelete);
        _schedules = new ConcurrentBag<TeachingSchedule>(remainingSchedules);
    }
}