namespace Labs.Entities;

public class Report
{
    public int UserID { get; set; }
    public int ReportID { get; set; }
    // public int OperatorID { get; set; }
    public DateTime GeneratedTimestamp { get; set; }
    public string Content { get; set; }
  

    // Конструктор за замовчуванням
    public Report()
    {
        // Ініціалізуємо властивості за замовчуванням
        ReportID = 0;
        UserID = 0;
        GeneratedTimestamp = DateTime.Now;
        Content = string.Empty;
    }

    // Конструктор, який приймає параметри
    public Report(int reportID, int operatorID)
    {
        ReportID = reportID;
        UserID = operatorID;
        GeneratedTimestamp = DateTime.Now;
        Content = string.Empty;
    }

    public void GenerateContent()
    {
        // Логіка для генерації контенту
    }
}