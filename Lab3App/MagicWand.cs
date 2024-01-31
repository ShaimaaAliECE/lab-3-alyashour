using System;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(string description)
        {
            Description = description;
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }

        protected override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }
    }
}