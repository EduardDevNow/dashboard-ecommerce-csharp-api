namespace DashboardEcommerce.DataAccess.Entities;

public class Status
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public string ColorStatus { get; set; }
    public string TranslationStatus { get; set; }
    public DateTime? CreatedAt { get; set; } = default(DateTime?);
    public DateTime? UpdatedAt { get; set; } = default(DateTime?);
}