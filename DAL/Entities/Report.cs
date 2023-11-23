﻿namespace Labs.Entities;

public class Report
{
    public int ReportID { get; set; }
    public string OperatorID { get; set; }
    public DateTime GeneratedTimestamp { get; set; }
    public string Content { get; set; }

    public Report(int reportID, string operatorID)
    {
        ReportID = reportID;
        OperatorID = operatorID;
        GeneratedTimestamp = DateTime.Now; // default timestamp
        Content = string.Empty; // default content
    }
    
    public void GenerateContent()
    {
      
    }
}