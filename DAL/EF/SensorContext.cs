using Labs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using MySql.Data.MySqlClient;
namespace Labs.EF
{
    public class SensorContext : DbContext
    {
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<AirQualitySensor> AirQualitySensors { get; set; }
        public DbSet<RadiationSensor> RadiationSensors { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<MeasurementHistory> MeasurementHistories { get; set; }
        public DbSet<AlarmSystem> AlarmSystems { get; set; }
        public DbSet<Operator> Operators { get; set; }

        
        
        public SensorContext(DbContextOptions options) : base(options)
        {
        }
        
        
       
        }
    


    }
