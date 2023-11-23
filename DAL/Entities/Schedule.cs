namespace Labs.Entities;

using System;
using System.Collections.Generic;

public class Schedule
{
    public List<Measurement> Measurements { get; set; }
    public List<Maintenance> Maintenance { get; set; }

    public Schedule()
    {
        Measurements = new List<Measurement>();
        Maintenance = new List<Maintenance>();
    }

    public void AddMeasurement(Measurement measurement)
    {
        Measurements.Add(measurement);
    }

    public void AddMaintenance(Maintenance maintenance)
    {
        Maintenance.Add(maintenance);
    }

    public List<Measurement> GetAllMeasurements()
    {
        return Measurements;
    }

    public List<Maintenance> GetAllMaintenance()
    {
        return Maintenance;
    }
}

