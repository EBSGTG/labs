namespace Labs.Entities;

public class RadiationSensor : Sensor
{
    public List<int> RadiationLevels { get; set; }

  
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