using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recovery.LIB
{

    public class DVD
    {
        public DVD() : this(TypeDVD.SimpleSide, 0.0, 0.0) { }
        public DVD(TypeDVD TypeDVD, double SpeedOfRead, double SpeedOfWrite)
        {
            this.TypeDVD = TypeDVD;
            this.SpeedOfRead = SpeedOfRead;
            this.SpeedOfWrite = SpeedOfWrite;
        }
        public double SpeedOfRead { get; set; }
        public double SpeedOfWrite { get; set; }
        public TypeDVD TypeDVD { get; set; }
    }
}
