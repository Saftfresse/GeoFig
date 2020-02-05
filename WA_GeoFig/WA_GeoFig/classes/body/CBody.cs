using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_GeoFig
{
    class CBody : CGeoFig
    {
        float volume;
        float surfaceArea;

        public float Volume { get => volume; set => volume = value; }
        public float SurfaceArea { get => surfaceArea; set => surfaceArea = value; }
    }
}
