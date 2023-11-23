namespace Labs.Entities;

public class RadiationSensor : Sensor
{
    public List<int> RadiationLevels { get; set; }

    public RadiationSensor(int sensorID, string location) : base(sensorID, location)
    {
        RadiationLevels = new List<int>();
    }
    public List<int> GetRadiationLevels()
    {
        return RadiationLevels;
    }

    public void AnalyzeRadiation()
    {
 
    }

    public void TransmitRadiationData()
    {

    }
}