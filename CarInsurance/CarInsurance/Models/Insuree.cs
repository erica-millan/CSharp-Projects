namespace CarInsurance.Models
{
    public class Insuree
    {
        /*
         * Id, FirstName, 
         * LastName, EmailAddress, 
         * DateOfBirth, CarYear, CarMake, 
         * CarModel, DUI, SpeedingTickets,
         * CoverageType, and Quote.
         * */

        public Guid Id { get; set; }
        public  required string FirstName { get; set; }
        public required string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }

        public string CarMake { get; set; }
        public string CarModel { get; set; }

        public bool DUI { get; set; }

        public int SpeedingTickets { get; set; }

        public string CoverageType { get; set; }

        public decimal Quote { get; set; }


    }
}
