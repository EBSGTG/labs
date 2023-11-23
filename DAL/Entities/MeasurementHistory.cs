namespace Labs.Entities;

public class MeasurementHistory
{
    public List<Measurement> Measurements { get; set; }

    public void AddMeasurement()
    {
       
    }

    public List<Measurement> GetMeasurementsInRange(DateTime startDate, DateTime endDate)
    {
       
        return new List<Measurement>();
    }

    public void ExportMeasurementsToCSV()
    {
       
    }
}