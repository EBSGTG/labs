namespace Labs.Entities;


public class Operator
{
    public int OperatorID { get; set; }
    public string Username { get; set; }

    public Operator(int operatorID, string username)
    {
        OperatorID = operatorID;
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