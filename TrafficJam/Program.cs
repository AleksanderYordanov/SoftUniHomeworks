using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            var passingCar = int.Parse(Console.ReadLine());

            var cars = new Queue<string>();
            var totalCarsPassed = 0;


            while (true)
            {
                var command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < passingCar; i++)
                    {
                        if (cars.Any())
                        {
                            totalCarsPassed++;
                            var currentCar = cars.Dequeue();
                            Console.WriteLine($"{currentCar} passed!");
                        }
                    }
                }
                else if (command == "end")
                {

                    break;
                }
                else
                {
                    cars.Enqueue(command);
                }
               
            }

            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}
