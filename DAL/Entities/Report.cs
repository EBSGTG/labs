namespace Labs.Entities;

public class Report
{
    public string ReportID { get; set; }
    public string OperatorID { get; set; }
    public DateTime GeneratedTimestamp { get; set; }
    public string Content { get; set; }

    public void GenerateContent()
    {
      
    }
}