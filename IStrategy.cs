﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    public interface IStrategy
    {
        List<Track> Process(Track track, string path);
    }
}
