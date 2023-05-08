using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repository.Entities
{
    public class Vaccination
    {

        public int id { get; set; }
        public string identity { get; set; }
        public DateTime date_vaccination { get; set; }
        public int producer { get; set; }

        public PersonalDetailes personalDetaile { get; set; }
        public Producer producer1 { get; set; }
    }
}
