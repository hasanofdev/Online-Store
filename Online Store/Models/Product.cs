using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Models;

public class Product
{
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }

    public Product(string name,string imageurl)
    {
        Name = name;
        ImageUrl = imageurl;
    }
}
