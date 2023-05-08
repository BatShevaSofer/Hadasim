using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO
{
    public class Class1
    {
        public static List<pokemon_details> GetAllCities()
        {
            try
            {
                using (pokemonEntities db = new pokemonEntities())
                {
                    return db.pokemon_details.ToList();
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

}

