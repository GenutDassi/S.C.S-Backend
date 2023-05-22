﻿using Dal.DataObject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Interfaces
{
    public interface IStationRepository : IRepository<Station>
    {
        public Station GetNearestStation(Station station);
    }
}
