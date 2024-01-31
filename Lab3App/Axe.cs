using System;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string description)
        {
            Description = description;
        }
        
        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }

        protected override void DoAction()
        {
            Console.WriteLine("Axe is Used.");
        }
    }
}