namespace Labs.BLL.DTO;

public class ReportDTO
{
    public int ReportID { get; set; }
    public int UserID { get; set; }
    public DateTime GeneratedTimestamp { get; set; }
    public string Content { get; set; }

    
}