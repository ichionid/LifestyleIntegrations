namespace StravaApp.Models;

public class MealEntry
{
    public int Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime LoggedAt { get; set; } = DateTime.UtcNow;

    // Nutrition fields from SnapCalorie
    public double Calories { get; set; }
    public double ProteinG { get; set; }
    public double CarbsG { get; set; }
    public double FatG { get; set; }
}