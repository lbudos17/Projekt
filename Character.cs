using System.Security.Cryptography.X509Certificates;

namespace Program 
{
    class Travel 
    {
        public string travelVehicle;
        public string travelDestination;
        public string travelAccommodation;
        

        public Travel (string travelVehicle, string travelDestination, string travelAccommodation) 
        {
            this.travelVehicle = travelVehicle;
            this.travelDestination = travelDestination;
            this.travelAccommodation = travelAccommodation;
            


        }
        public void print() {
            Console.WriteLine("Travel Vehicle: " + travelVehicle + "\nTravel Destination: " + travelDestination + "\nTravel Accommodation: " + travelAccommodation);
        }

    }
}