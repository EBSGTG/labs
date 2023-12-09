namespace Labs.Entities;

using System;

public class Schedule
{
    public List<Measurement> Measurements { get;  }
    public List<Maintenance> Maintenance { get;  }
    

    public List<Measurement> GetAllMeasurements()
    {
        return Measurements;
    }

    public List<Maintenance> GetAllMaintenance()
    {
        return Maintenance;
    }
}

