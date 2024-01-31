using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int Value;

        public Coin(string description, int score, int value)
        {
            Description = description;
            Score = score;
            Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
        
        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}