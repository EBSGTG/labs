namespace Labs.Entities;

public class Maintenance
{
    public string MaintenanceID { get; set; }
    public DateTime PlannedTimestamp { get; set; }
    public string Description { get; set; }

    public void PlanMaintenance()
    {
        
    }

    public List<Maintenance> ViewScheduledMaintenance()
    {
        return new List<Maintenance>();
    }
}