namespace Labs.Entities;

public class Sensor
{

    public int SensorID { get; set; }
    public string Location { get; set; }
    public List<Measurement> Readings { get; set; }
    public StatusEnum Status { get; set; }

    



    public List<Measurement> GetReadings()
    {
        return Readings;
    }

    public void AnalyzeData()
    {
       
    }

    public void StoreData()
    {
 
    }

    public void TransmitData()
    {
       
    }
}