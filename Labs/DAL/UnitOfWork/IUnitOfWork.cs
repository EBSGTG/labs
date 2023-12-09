using Labs.Repositories.Interfaces;

namespace Labs.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAirQualitySensorRepository AirQualitySensors { get; }
        IAlarmSystemRepository AlarmSystems { get; }
        IMaintenanceRepository Maintenances { get; }
        IMeasurementHistoryRepository MeasurementHistories { get; }
        IMeasurementRepository Measurements { get; }
        IOperatorRepository Operators { get; }
        IRadiationSensorRepository RadiationSensors { get; }
        IReportRepository Reports { get; }
        IScheduleRepository Schedules { get; }
        ISensorRepository Sensors { get; }
        IStatisticsRepository Statisticses { get; }
        
        void Save();
    }
}