﻿using System;
using System.Collections.Generic;

namespace Dal.DataObject;

public partial class Station
{
    public int Id { get; set; }

    public double X { get; set; }

    public double Y { get; set; }

    public int? Number { get; set; }

    public int StreetId { get; set; }

    public bool? IsCenteral { get; set; }

    public virtual ICollection<StationToCar> StationToCars { get; } = new List<StationToCar>();

    public virtual Street Street { get; set; } = null!;

}
