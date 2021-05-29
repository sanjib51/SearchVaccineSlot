﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvailableVaccine.Shared
{
    public class AvailableDose
    {
    }
}


public class Rootobject
{
    public Center[] centers { get; set; }
}

public class Center
{
    public int center_id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public string state_name { get; set; }
    public string district_name { get; set; }
    public string block_name { get; set; }
    public int pincode { get; set; }
    public int lat { get; set; }
    public int _long { get; set; }
    public string from { get; set; }
    public string to { get; set; }
    public string fee_type { get; set; }
    public Session[] sessions { get; set; }
    public Vaccine_Fees[] vaccine_fees { get; set; }
}

public class Session
{
    public string session_id { get; set; }
    public string date { get; set; }
    public int available_capacity { get; set; }
    public int min_age_limit { get; set; }
    public string vaccine { get; set; }
    public string[] slots { get; set; }
    public int available_capacity_dose1 { get; set; }
    public int available_capacity_dose2 { get; set; }
}

public class Vaccine_Fees
{
    public string vaccine { get; set; }
    public string fee { get; set; }
}

