namespace NET1704_221_ASM4_SE170128_TranTruongVan;

public class TeachingSchedule
{
    public int Id { get; set; }

    public string Tutor { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Slot { get; set; } = null!;

    public string MeetRoomCode { get; set; } = null!;

    public string RoomPassword { get; set; } = null!;

    public string LearnDays { get; set; } = null!; //Example: "Monday,Wednesday,Friday"

    public bool IsDelete { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime LastUpdated { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}