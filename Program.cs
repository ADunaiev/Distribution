using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Разработать архитектуру классов иерархии товаров при разработке 
//системы управления потоками товаров для дистрибьюторской компании. 
//Прописать члены классов. Создать диаграммы взаимоотношений классов. 
//Должны быть предусмотрены разные типы товаров, в том числе: • бытовая 
//химия; • продукты питания.Предусмотреть классы управления потоком товаров 
//    (пришло, реализовано, списано, передано). 

namespace Distribution
{

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Product
    {
        private int id
        {
            get => default;
            set
            {
            }
        }

        private string name
        {
            get => default;
            set
            {
            }
        }

        private decimal price
        {
            get => default;
            set
            {
            }
        }
        public AbstractCategory Category { get; set; }
        public Product(int _id, string _name, decimal _price)
        {
            id = _id;
            name = _name;   
            price = _price;
        }
        public override string ToString()
        {
            string temp = $"Product {name}, id {id}, price - {price}.";
            Console.WriteLine(temp);
            return temp;
        }
    }

    public abstract class AbstractCategory
    {
        protected int CategoryID { get; set; }
        protected string CategoryName { get; set; }
        public Product[] CategoryProducts { get; set; }

        public abstract void Received(Product[] ReceivedProducts, int[] Received_Quantity);
        public abstract void Sold(Product[] SoldProducts, int[] SoldQuantity);
        public abstract void WriteOff(Product[] WriteOffProducts, int[] WriteOffQuantity);
        public abstract void Shipped(Product[] ShippedProducts, int[] ShippedQuantity);
    }
    class HouseholdChemical : AbstractCategory
    {
        public HouseholdChemical(Product[] _HCList)
        {
            HCList = _HCList;
        }
        public override void Received(Product[] ReceivedProducts, int[] Received_Quantity)
        { }
        public override void Sold(Product[] SoldProducts, int[] SoldQuantity)
        { }
        public override void WriteOff(Product[] WriteOffProducts, int[] WriteOffQuantity)
        { }
        public override void Shipped(Product[] ShippedProducts, int[] ShippedQuantity)
        { }


    }

    public class ProductLot
    {
        private int Quantity
        {
            get => default;
            set
            {
            }
        }
        private Product Prod
        {
            get => default;
            set
            {
            }
        }

        public int Amount
        {
            get => default;
            set
            {
            }
        }
    }
}
