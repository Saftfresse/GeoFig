using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA_GeoFig
{
    class CPlane : CGeoFig
    {
        float area;
        float perimeter;

        public float Area { get => area; set => area = value; }
        public float Perimeter { get => perimeter; set => perimeter = value; }
    }
}
