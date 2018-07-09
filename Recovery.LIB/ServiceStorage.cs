using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recovery.LIB
{
    public enum TypeDevice
    {
        Flash, DVD, HDD
    }

    public class ServiceStorage
    {
        static List<Flash> Flashes;
        static ServiceStorage()
        {
            Flashes = new List<Flash>();
        }
        public static void AddFlash(Flash flash)
        {
            Flashes.Add(flash);
        }
        static double totalMemory;
        public static double GetMemoryDevice()
        {
            totalMemory = Flashes.Sum(s => s.GetMemory()/*Лямбда выражения*/);
            Console.WriteLine("Объем всех носителей = {0}", totalMemory);
            return totalMemory;
        }
        public static double GetFreeMemoryDevice()
        {
            totalMemory = Flashes.Sum(s => s.GetFreeMemory()/*Лямбда выражения*/);
            Console.WriteLine("Свободный объем всех носителей = {0}", totalMemory);
            return totalMemory;
        }
        public static void GetCountDevice(TypeDevice typeDevice, double sizeData)
        {
            double total = 0;
            switch (typeDevice)
            {
                case TypeDevice.Flash:
                    {
                        int i = 1;
                        foreach (Flash item in Flashes)
                        {
                            total = Math.Floor(sizeData / item.Memory);
                            if (total == 0)
                                total++;
                            Console.WriteLine("{0}. {1} ({2}) - {3}Mb \t - {4}штук",
                                i++, item.Name, item.Model, item.Memory, total);
                        }
                        Console.WriteLine("Введите тип флешки");
                        i = Int32.Parse(Console.ReadLine());
                        GetTimeToCopy(typeDevice, i, sizeData);
                    }
                    break;
                case TypeDevice.DVD:
                    {

                    }
                    break;
                case TypeDevice.HDD:
                    {

                    }
                    break;
                default:
                    break;
            }
        }
        public static void GetTimeToCopy(TypeDevice typeDevice,int choise,double sizeData)
        {

            switch (typeDevice)
            {
                case TypeDevice.Flash:
                    {
                        Flash chFlash = Flashes[choise-1];

                        int coutDevice = 3;
                        Flash[] flashesD = new Flash[coutDevice];
                        for (int i = 0; i < coutDevice; i++)
                        {
                            flashesD[i] = chFlash;

                            if (i == coutDevice - 1)
                                flashesD[i].CopyData(sizeData);

                            flashesD[i].CopyData(flashesD[i].Memory);
                            sizeData -= flashesD[i].Memory;
                        }
                    }
                    break;
                case TypeDevice.DVD:
                    break;
                case TypeDevice.HDD:
                    break;
                default:
                    break;
            }

        }
    }
}
