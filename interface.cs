using System.Net;
using System.Reflection;

namespace Program 
{
    interface IOsoba 
    {
        public string adresa {get; set;}
        public string grad {get; set;}
        public string telefon {get; set;}
    }

    interface IFizicka 
    {
        public string ime {get; set;}
        public string prezime {get;set;}
    }

    class FizickeOsobe : IOsoba, IFizicka 
    {
        public string ime {get; set;} = "Ime fizicke osobe";
        public string prezime {get;set;} = "Prezime fizicke osobe";
        public string adresa {get; set;} = "Adresa fizicke osobe";
        public string grad {get; set;} = "Grad fizicke osobe";
        public string telefon {get; set;} = "Telefon fizicke osobe";

        public FizickeOsobe() 
        {
            
        }
    }
    class PravneOsobe : IOsoba 
    {
        public string naziv {get; set;}
        public string adresa {get; set;} = "Adresa fizicke osobe";
        public string grad {get; set;} = "Grad fizicke osobe";
        public string telefon {get; set;} = "Telefon fizicke osobe";
    }
}
    