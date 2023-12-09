namespace Labs.BLL.DTO
{
public class MeasurementDTO
{
        public int MeasurementID { get; set; }
        public string SensorID { get; set; }
        public DateTime Timestamp { get; set; }
        public double Value { get; set; }
}

}