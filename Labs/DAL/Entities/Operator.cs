namespace Labs.Entities;


public class Operator
{
    public int OperatorID { get; set; }
    public string Username { get; set; }

    public Operator(int operatorId, string username)
    {
        OperatorID = operatorId;
        Username = username;
    }
    
    public void GenerateReport()
    {
      
    }

    public void ViewStatistics()
    {
      
    }

    public void DetectDeviation()
    {
       
    }

    public void PlanMeasurements()
    {
     
    }

    public void PlanMaintenance()
    {
       
    }
}