using System.Collections.Generic;

namespace XFFurniture.Models
{
    public class Product
    {
        public Product()
        {
            this.colors = new List<Color>();
        }

        public string description { get; set; }
        public double rating { get; set; }
        public int review { get; set; }
        public double oldPrice { get; set; }
        public double newPrice { get; set; }
        public bool favorite { get; set; }
        public double discount { get; set; }
        public string image { get; set; }
        public List<Color> colors { get; set; }
        public string createdBy { get; set; }
        public string overview { get; set; }
    }

    public class Color
    {
        public string color { get; set; }
        public bool selected { get; set; }
    }
}
