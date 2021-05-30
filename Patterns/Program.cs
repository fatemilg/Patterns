﻿using Patterns.ChainOfResponsibility;
using Patterns.Decorator;
using Patterns.FactoryPattern.VehicleFactory;
using Patterns.FamilyTax;
using Patterns.FamilyTax.Calculator;
using Patterns.FamilyTax.Entity;
using Patterns.FamilyTax.Hub;
using Patterns.Strategy;
using System;
using System.Collections;
using SortedList = Patterns.Strategy.SortedList;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Factory Pattern-----------------");
            IVehicleFactory carfactory = new CarFactory();
            var car = carfactory.CreateVehicle();
            car.Drive(20);
            car.FuelConsumption();

            IVehicleFactory bikefactory = new BikeFactory();
            var bike = bikefactory.CreateVehicle();
            bike.Drive(5);
            bike.FuelConsumption();

            Console.WriteLine("----------------------Decorator Pattern-----------------");
            Cake cc1 = new Cake();
            Console.WriteLine(cc1.Bake() + " ," + cc1.GetPrice());

            Type1 cd1 = new Type1(cc1);
            Console.WriteLine(cd1.Bake() + " ," + cd1.GetPrice());

            Type2 cd2 = new Type2(cc1);
            Console.WriteLine(cd2.Bake() + " ," + cd2.GetPrice());




            Console.WriteLine("----------------------Visitor Pattern-----------------");
            IElementFamily darman = new Darman();
            IElementFamily dandan = new Dandan();
            IElementFamily para = new Para();

            var hub = new Hub();
            hub.Attach(darman);
            hub.Attach(dandan);
            hub.Attach(para);

            hub.Execute(new TaxCalculator());
            hub.Execute(new InvoiceCalculator());


            Console.WriteLine("----------------------Strategy Pattern-----------------");
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();



            Console.WriteLine("----------------------Chain Of Responsibility Pattern-----------------");
            var fromCustomer = new Customer()
            {
                AccountValue = 1000,
                IsActive = true,
                MaxDateValue = 100,
                Password = "1234",
            };
            Customer toCustomer = new Customer()
            {
                AccountValue = 10000,
                IsActive = true,
                MaxDateValue = 2000,
                Password = "1234",
            };
            var transfer = new CheckPassword(new CheckValue(new CheckActive(new FinalTransfer(null))));
            var result = transfer.Execute(new RequestContext()
            {
                FromCustomer = fromCustomer,
                ToCustomer = toCustomer,
                Password = "1234",
                Value = 150,
            });
            Console.WriteLine(result.Message);
            Console.ReadKey();
        }

    }
}