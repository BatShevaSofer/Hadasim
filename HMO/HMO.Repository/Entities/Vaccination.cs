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
        public virtual ICollection<PersonalDetailes> identity { get; set; }
      
        public DateTime date_vaccination { get; set; }
        public virtual ICollection<Producer> producer { get; set; }

    }
}
