namespace Labs.Entities;
public class Statistics
{
    public int StatisticsID { get; set; }
    public double Data { get; set; }

    public Statistics(int statisticsID, double data)
    {
        StatisticsID = statisticsID;
        Data = data;
    }
    public void UpdateStatistics()
    {
        
    }

    public object GetStatistics()
    {
       
        return new object();
    }
}