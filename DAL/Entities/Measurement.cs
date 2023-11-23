namespace Labs.Entities;

public class Measurement
{
    public string MeasurementID { get; set; }
    public string SensorID { get; set; }
    public DateTime Timestamp { get; set; }
    public double Value { get; set; }

    public Measurement(string measurementID, string sensorID, double value)
    {
        MeasurementID = measurementID;
        SensorID = sensorID;
        Timestamp = DateTime.Now; // default timestamp
        Value = value;
    }
    public void RecordMeasurement()
    {
        // Записує нове вимірювання
    }

    public List<Measurement> GetMeasurementHistory()
    {
        // Повертає історію вимірювань
        return new List<Measurement>();
    }
}