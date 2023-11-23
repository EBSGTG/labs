using Labs.Entities;
using Labs.Repositories.Impl;
using Labs.Repositories.Interfaces;
using Labs.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace Labs.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public  SensorContext db;
        private SensorRepository sensorRepository;
        private AirQualitySensorRepository airQualitySensorRepository;
        private RadiationSensorRepository radiationSensorRepository;
        private MeasurementRepository measurementRepository;
        private StatisticsRepository statisticsRepository;
        private ReportRepository reportRepository;
        private MaintenanceRepository maintenanceRepository;
        private MeasurementHistoryRepository measurementHistoryRepository;
        private AlarmSystemRepository alarmSystemRepository;
        private OperatorRepository operatorRepository;
        private ScheduleRepository scheduleRepository;

        public EFUnitOfWork(DbContextOptions options)
        {
            db = new SensorContext(options);
        }

       

        public ISensorRepository Sensors
        {
            get
            {
                if (sensorRepository == null)
                    sensorRepository = new SensorRepository(db);
                return sensorRepository;
            }
        }

        public IAirQualitySensorRepository AirQualitySensors
        {
            get
            {
                if (airQualitySensorRepository == null)
                    airQualitySensorRepository = new AirQualitySensorRepository(db);
                return airQualitySensorRepository;
            }
        }
        
        public IScheduleRepository Schedules
        {
            get
            {
                if (scheduleRepository == null)
                    scheduleRepository = new ScheduleRepository(db);
                return scheduleRepository;
            }
        }

        public IRadiationSensorRepository RadiationSensors
        {
            get
            {
                if (radiationSensorRepository == null)
                    radiationSensorRepository = new RadiationSensorRepository(db);
                return radiationSensorRepository;
            }
        }

        public IMeasurementRepository Measurements
        {
            get
            {
                if (measurementRepository == null)
                    measurementRepository = new MeasurementRepository(db);
                return measurementRepository;
            }
        }

        public IStatisticsRepository Statisticses
        {
            get
            {
                if (statisticsRepository == null)
                    statisticsRepository = new StatisticsRepository(db);
                return statisticsRepository;
            }
        }

        public IReportRepository Reports
        {
            get
            {
                if (reportRepository == null)
                    reportRepository = new ReportRepository(db);
                return reportRepository;
            }
        }

        public IMaintenanceRepository Maintenances
        {
            get
            {
                if (maintenanceRepository == null)
                    maintenanceRepository = new MaintenanceRepository(db);
                return maintenanceRepository;
            }
        }

        public IMeasurementHistoryRepository MeasurementHistories
        {
            get
            {
                if (measurementHistoryRepository == null)
                    measurementHistoryRepository = new MeasurementHistoryRepository(db);
                return measurementHistoryRepository;
            }
        }

        public IAlarmSystemRepository AlarmSystems
        {
            get
            {
                if (alarmSystemRepository == null)
                    alarmSystemRepository = new AlarmSystemRepository(db);
                return alarmSystemRepository;
            }
        }

        public IOperatorRepository Operators
        {
            get
            {
                if (operatorRepository == null)
                    operatorRepository = new OperatorRepository(db);
                return operatorRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        private bool disposed = false;
        private IUnitOfWork _unitOfWorkImplementation;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}