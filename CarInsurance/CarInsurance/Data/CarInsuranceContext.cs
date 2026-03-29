using CarInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    //Inherit from db context class from the entity framework core package installed.
    public class CarInsuranceContext : DbContext
    //DbContext represents a session with the database and allows Entity
    //Framework to access it and interact with the data like objects
    {
        //constructor for context class
        //adding parameter to constructor to pass the db info
        //Our parameter will be the DbContextOptions<TContext>
        //class and we will pass our database context to it. 
        //We will name the parameter “options.” 
        public CarInsuranceContext(DbContextOptions<CarInsuranceContext> options) : base(options)
        {
            
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
