using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELnovi.Models
{
    public class IzvorFinanciranja
    {
        public int Id { get; set; }
        public string Iznos { get; set; }
        public string Naziv { get; set; }
        
        public override string ToString()
        {
            return Naziv; // da bas pise taj tekst, a ne ono models bla bla
        }
    }
}
