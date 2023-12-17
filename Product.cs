using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1
{
    class Product:MyInterface
    {
        public int id;
        public string name;
        public int price;

        public void getData()
        {
            Console.WriteLine("ID       : " + id);
            Console.WriteLine("Name     : " + name);
            Console.WriteLine("Credit   : " + price);
        }

        public void setData()
        {
            Console.Write("Enter ID: ");
            id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Price: ");
            price = int.Parse(Console.ReadLine());
        }

        public void storeData()
        {
            throw new NotImplementedException();
        }
    }
}
