using System.Collections.Generic;
using System.Collections.ObjectModel;
using XFFurniture.Models;

namespace XFFurniture.Service
{
    public class DataService
    {
        public static ObservableCollection<Category> GetCategories()
        {
            return new ObservableCollection<Category>()
            {
                new Category()
                {
                    description = "Chairs",
                    numberItems = 4512,
                    image = "armchair.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Category()
                {
                    description = "Lamps",
                    numberItems = 512,
                    image = "lamp.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Category()
                {
                    description = "TV Stand",
                    numberItems = 1815,
                    image = "tvstand.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
            };
        }

        public static ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>()
            {
                new Product()
                {
                    description = "Armchair 1",
                    rating = 4.5,
                    review = 463,
                    oldPrice = 8152,
                    newPrice = 6114,
                    favorite = true,
                    discount = 25,
                    image = "chair1",
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0", selected = true },
                        new Color(){ color = "#54889A" },
                        new Color(){ color = "#3B3B3B" }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new Product()
                {
                    description = "Armchair 2",
                    rating = 4.5,
                    review = 263,
                    oldPrice = 0,
                    newPrice = 2515,
                    favorite = false,
                    discount = 0,
                    image = "chair2",
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A", selected = true },
                        new Color(){ color = "#3B3B3B" }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new Product()
                {
                    description = "Armchair 3",
                    rating = 3.8,
                    review = 158,
                    oldPrice = 0,
                    newPrice = 1580,
                    favorite = false,
                    discount = 0,
                    image = "chair3",
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A" },
                        new Color(){ color = "#3B3B3B", selected = true }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new Product()
                {
                    description = "Armchair 4",
                    rating = 4.8,
                    review = 525,
                    oldPrice = 0,
                    newPrice = 2199,
                    favorite = true,
                    discount = 0,
                    image = "chair4",
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A", selected = true },
                        new Color(){ color = "#3B3B3B" }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new Product()
                {
                    description = "Armchair 5",
                    rating = 4,
                    review = 718,
                    oldPrice = 1589,
                    newPrice = 3650,
                    favorite = true,
                    discount = 15,
                    image = "chair",
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A" },
                        new Color(){ color = "#3B3B3B", selected = true }
                    },
                    overview = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. \n\nDuis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    createdBy = "Xamarin Forms"
                },
                new Product()
                {
                    description = "Flamingo 2 Seater Sofa in Blue colour",
                    rating = 5,
                    review = 890,
                    oldPrice = 0,
                    newPrice = 6599,
                    favorite = true,
                    discount = 0,
                    image = "sofa",
                    colors = new List<Color>()
                    {
                        new Color(){ color = "#9AADB0" },
                        new Color(){ color = "#54889A", selected = true },
                        new Color(){ color = "#C5BAA4" },
                        new Color(){ color = "#EFCBAF" },
                        new Color(){ color = "#3B3B3B" }
                    },
                    overview = "Homez offers Furniture at affordable prices with the best quality and durability with modern designs. Our aim is to meet the necessity of home decor and for the ones who are looking for premium and trending seating solutions.\n\nBucket Style Sofas have rounded or contoured back. The earliest bucket sofas had high sides and were named for their resemblance to buckets.\n\nFurniture bought on Homez.com is shipped for free. So go ahead and buy with confidence.",
                    createdBy = "Xamarin Forms"
                },
            };
        }
    }
}
