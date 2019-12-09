using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            //implementation for g


            //implementation for h


            Console.WriteLine("Complete");
            Console.ReadKey();
        }

        /// <summary>
        /// base class for IDs
        /// </summary>
        public abstract class Entity<T>
        {
            public Entity(T id)
            {
                Id = id;
            }            

            public T Id { get; set; }
        }

        /// <summary>
        /// examples of makes of vehicle are Mercedes-Benz, Audi, Toyota, etc
        /// </summary>
        public class VehicleMake : Entity<Guid>
        {
            public VehicleMake(Guid id) : base(id)
            {

            }

            public string Description { get; set; }
        }

        /// <summary>
        /// examples of vehicle models are A 180 avantgarde or Corolla 1.6 GLE
        /// </summary>
        public class VehicleModel : Entity<Guid>
        {
            public VehicleModel(Guid id) : base(id)
            {

            }

            public string Description { get; set; }
        }

        /// <summary>
        /// This has the price or the vehicle for a given year
        /// </summary>
        public class VehiclePrice : Entity<Guid>
        {
            public VehiclePrice(Guid id) : base(id)
            {

            }

            public int Year { get; set; }
            public decimal Price { get; set; }
        }
    }
}
