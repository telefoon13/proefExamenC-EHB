using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Student : EntitiyBase, IAuditable, IValidatable
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime GeboorteDatum { get; set; }

        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(Voornaam))
                return false;

            if (string.IsNullOrWhiteSpace(Achternaam))
                return false;

            var ageInYears = new DateTime (DateTime.Now.Subtract(GeboorteDatum).Ticks).Year-1;
            if (ageInYears < 15 || ageInYears > 100)
                return false;

            return true;  
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}, {2}", ID, Voornaam, Achternaam);
        }
    }
}
