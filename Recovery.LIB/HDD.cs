using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recovery.LIB
{
    class HDD
    {
        public HDD() : this(TypeUSB.USB1, 0, 0.0) { }
        public HDD(TypeUSB TypeUSB, int KolRazd, double ObemRazd)
        {
            this.TypeUSB = TypeUSB;
            this.KolRazd = KolRazd;
            this.ObemRazd = ObemRazd;
        }
        public TypeUSB TypeUSB { get; set; }
        public int KolRazd { get; set; }
        public double ObemRazd { get; set; }
    }
}
