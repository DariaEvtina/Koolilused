using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Koolilused.Models
{
    public class Opetaja
    {
        public int Id { get; set; }
        public string OpetajaEesnimi { get; set; }
        public string OpetajaPerenimi { get; set; }
        public int Telefon { get; set; }
    }
}