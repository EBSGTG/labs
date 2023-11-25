namespace Labs.Entities;

public class Measurement
{
    public int MeasurementID { get; set; }
    public string SensorID { get; set; }
    public DateTime Timestamp { get; set; }
    public double Value { get; set; }

    public Measurement(int measurementID, string sensorID, double value)
    {
        MeasurementID = measurementID;
        SensorID = sensorID;
        Timestamp = DateTime.Now; 
        Value = value;
    }
    public void RecordMeasurement()
    {
    
    }

    public List<Measurement> GetMeasurementHistory()
    {
        
        return new List<Measurement>();
    }
}