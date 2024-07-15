namespace NET1704_221_ASM4_SE170128_TranTruongVan;

public class InitialData
{
    public static readonly List<TeachingSchedule> Schedules =
    [
        new TeachingSchedule
        {
            Id = 1,
            Tutor = "John Doe",
            Subject = "Math",
            Slot = "Slot 1", //1-4
            MeetRoomCode = "pup-zhj-sjb",
            RoomPassword = "@Password123",
            LearnDays = "Monday,Wednesday,Friday",
            IsDelete = false,
            CreationDate = DateTime.Now,
            LastUpdated = DateTime.Now,
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(2))
        },
        new TeachingSchedule
        {
            Id = 2,
            Tutor = "Jane Smith",
            Subject = "Science",
            Slot = "Slot 2",
            MeetRoomCode = "mno-pqr-stu",
            RoomPassword = "@Science456",
            LearnDays = "Tuesday,Thursday",
            IsDelete = true,
            CreationDate = DateTime.Now,
            LastUpdated = DateTime.Now,
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(2))
        },
        new TeachingSchedule
        {
            Id = 3,
            Tutor = "Alice Johnson",
            Subject = "English",
            Slot = "Slot 3",
            MeetRoomCode = "abc-def-ghi",
            RoomPassword = "@English789",
            LearnDays = "Monday,Wednesday,Friday",
            IsDelete = false,
            CreationDate = DateTime.Now,
            LastUpdated = DateTime.Now,
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(2))
        },
        new TeachingSchedule
        {
            Id = 4,
            Tutor = "Bob Brown",
            Subject = "History",
            Slot = "Slot 4",
            MeetRoomCode = "xyz-lmn-opq",
            RoomPassword = "@History012",
            LearnDays = "Tuesday,Thursday",
            IsDelete = true,
            CreationDate = DateTime.Now,
            LastUpdated = DateTime.Now,
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(2))
        },
        new TeachingSchedule
        {
            Id = 5,
            Tutor = "Chris Green",
            Subject = "Physics",
            Slot = "Slot 1",
            MeetRoomCode = "rst-uvw-xyz",
            RoomPassword = "@Physics345",
            LearnDays = "Monday,Wednesday,Friday",
            IsDelete = false,
            CreationDate = DateTime.Now,
            LastUpdated = DateTime.Now,
            StartDate = DateOnly.FromDateTime(DateTime.Now),
            EndDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(2))
        }
    ];
}