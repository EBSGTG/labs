namespace Labs.Entities;

public class Maintenance
{
    public int MaintenanceID { get; set; }
    public DateTime PlannedTimestamp { get; set; }
    public string Description { get; set; }

    public Maintenance(int maintenanceID, DateTime plannedTimestamp, string description)
    {
        MaintenanceID = maintenanceID;
        PlannedTimestamp = plannedTimestamp;
        Description = description;
    }
    
    public void PlanMaintenance()
    {
        
    }

    public List<Maintenance> ViewScheduledMaintenance()
    {
        return new List<Maintenance>();
    }
}