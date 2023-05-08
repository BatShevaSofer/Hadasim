using HMO.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Common.DTO
{
    public class VaccinationDTO
    {
        public int id { get; set; }
        public PersonalDetailes identity { get; set; }
        public DateTime date_vaccination { get; set; }
        public Producer producer { get; set; }

    }
}
