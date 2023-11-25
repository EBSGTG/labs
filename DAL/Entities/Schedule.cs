namespace Labs.Entities;

using System;
using System.Collections.Generic;

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

