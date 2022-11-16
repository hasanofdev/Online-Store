using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store.Models;

public class ProductItem : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    public void NotifyPropertyChanged([CallerMemberName] string propertyName="")
        =>PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public Guid ID { get; set; }
    public Product? Product { get; set; }

    private uint _count;
    public uint Count
    {
        get { return _count; }
        set { _count = value; NotifyPropertyChanged(); }
    }

    public decimal Price { get; set; }

    public ProductItem(Product product,uint count,decimal price)
    {
        ID = Guid.NewGuid();
        Product = product;
        Count = count;
        Price = price;
    }
}
