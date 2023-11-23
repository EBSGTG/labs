namespace Labs.Entities;

public class AirQualitySensor : Sensor
{
    public List<int> PollutantLevels { get; set; }

    public AirQualitySensor(int sensorID, string location) : base(sensorID, location)
    {
        PollutantLevels = new List<int>();
    }
    public List<int> GetPollutantLevels()
    {
        return PollutantLevels;
    }

    public void AnalyzeAirQuality()
    {
        // Аналізує якість повітря
    }

    public void TransmitAirQualityData()
    {
        // Передає дані якості повітря на сервер
    }
}