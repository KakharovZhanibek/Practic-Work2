using Recovery.LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Flash flash1 = new Flash(2000,TypeUSB.USB1);
            flash1.Name = "Kingston";
            flash1.Model = "KB12";
            
            ServiceStorage.AddFlash(flash1);


            ServiceStorage.AddFlash(new Flash(4000, TypeUSB.USB2) { Name = "Transend", Model = "B125" });
            ServiceStorage.AddFlash(new Flash(8000, TypeUSB.USB3) { Name = "Samsung", Model = "S13G" });
            Console.WriteLine("Введите объем информации");
            double t = double.Parse(Console.ReadLine());
            ServiceStorage.GetCountDevice(TypeDevice.Flash, t);
        }
    }
}
