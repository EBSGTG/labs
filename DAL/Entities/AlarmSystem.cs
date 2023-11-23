namespace Labs.Entities;

public class AlarmSystem
{
    public List<string> Alarms { get; set; }

    public void TriggerAlarm()
    {
        // Запускає сигнал оповіщення
    }

    public void ResetAlarm()
    {
        // Скидає стан оповіщення
    }

    public List<string> ViewAlarmHistory()
    {
        // Переглядає історію оповіщень
        return new List<string>();
    }
}