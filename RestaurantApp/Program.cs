using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello TIT.1/1");
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };

        }
    }
    public class Restaurant
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string type {  get; set; }
        private double rate { get; set; }

        public Restaurant(int id,string name,string t,double r) 
        {
            this.Id = id;
            this.Name = name;
            this.type = t;
            this.rate = r;
        }

    }
}
