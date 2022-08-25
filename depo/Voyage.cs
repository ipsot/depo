using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depo
{
    class Voyage
    {
        public int Id { get; set; }
        public int Id_driver { get; set; }
        public int Id_route { get; set; }
        public DateTime Time_start { get; set; }
        public DateTime Time_finish { get; set; }
    }
}
