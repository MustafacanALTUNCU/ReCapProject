// See https://aka.ms/new-console-template for more information
using Bussiness.Concrate;
using DataAccess.Concrate.InMemory;
using System;

namespace ReCapProject // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryProductDal());
            int sayi = Convert.ToInt32(Console.ReadLine());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carManager.GetById(sayi))
            {
                Console.WriteLine(car.Description);
            }   
        }
    }
}