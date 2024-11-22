using System;
using paterni_povidenia.Collections;
using paterni_povidenia.Models;


namespace paterni_povidenia
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = new OpticalSystem();
            system.AddElement(new Lens());
            system.AddElement(new Mirror());
            system.AddElement(new Converter());

           
            Console.WriteLine("Обход оптической системы:");
            foreach (var element in system)
            {
                Console.WriteLine($" - {element.GetName()}");
            }
        }
    }
}
