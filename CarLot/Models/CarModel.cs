namespace CarLot.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class CarModel : DbContext
    {
        // Your context has been configured to use a 'CarModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CarLot.Models.CarModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarModel' 
        // connection string in the application configuration file.
        public CarModel()
            : base("name=CarModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Lot> Lots { get; set; }
        public DbSet<Car> Cars { get; set; }
    }

    public class Lot
    {
        //Primary Key
        public int LotID { get; set; }
        public string Name { get; set; }

        public string Section { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }

    public class Car
    {
        public int CarId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int Price { get; set; }

        public bool isNew { get; set; }


        //foreign key
        public int LotID { get; set; }
        public virtual Lot lot { get; set; }
    }


}