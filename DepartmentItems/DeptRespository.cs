using Items.Entity;
using System;
using System.Collections.Generic;


namespace DepartmentItems.Repository
{
    public class DeptRespository
    {
        public static List<Products> products = new List<Products>();
        static DeptRespository()
        {
            products.Add(new Products { ProductId = 1, ProductName = "Cadbury Chocholate", Description = "1 x Cadbury Dairy Milk Silk Chocolate Bar (150g)", rupees = 160 });
            products.Add(new Products { ProductId = 2, ProductName = "Trolley", Description = "AmazonBasics 78 cm Burnt Orange Hardsided Check-in Trolley", rupees =  4229 });
            products.Add(new Products { ProductId = 3, ProductName = "Boat Earphones", Description = "boAt Rockerz 255 Sports Bluetooth Wireless Earphone with Immersive Stereo Sound and Hands Free Mic (Neon)", rupees = 1500 });
            products.Add(new Products { ProductId = 4, ProductName = "HP Omen Gaming Laptop", Description = "HP Omen Core i7 9th Gen 15.6-inch FHD Gaming Laptop (16GB/1TB HDD + 512GB SSD/Windows 10/NVIDIA GTX 1650 4GB Graphics/Shadow Black), 15-dh0135TX", rupees =120000  });
            products.Add(new Products { ProductId = 5, ProductName = "OnePlus 7T (8GB RAM)", Description = "OnePlus 7T (Frosted Silver, 8GB RAM, Fluid AMOLED Display, 128GB Storage, 3800mAH Battery)", rupees = 35000 });
            products.Add(new Products { ProductId = 6, ProductName = "Trolley", Description = "AmazonBasics 78 cm Burnt Orange Hardsided Check-in Trolley", rupees = 4229 });
            products.Add(new Products { ProductId = 7, ProductName = "Canon EOS 1500D Digital Camera (Black)", Description = "Canon EOS 1500D 24.1 Digital SLR Camera (Black) with EF S18-55 is II Lens, 16GB Card and Carry Case", rupees = 25990 });
        }
        public IEnumerable<Products> GetAllProducts()
        {
            return products;
        }
    }
}
