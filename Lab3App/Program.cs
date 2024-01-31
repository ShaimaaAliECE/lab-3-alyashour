using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a collection board
            CollectionBoard board = new CollectionBoard();

            List<Collectable> possibleCollectables = new List<Collectable>();
            // Three coins 
            possibleCollectables.Add(new Coin("Nickel", score:20, value:5));
            possibleCollectables.Add(new Coin("Dime", score:40, value:10));
            possibleCollectables.Add(new Coin("Toony", score: 50, value: 100));

            // Five Diamonds with descriptions Diamond1, Diamond2, ... etc.
            for (int i = 1;i <= 5; i++)
            {
                possibleCollectables.Add(new Diamond("Diamond"+ i, score: 100));
            }

            // One Axe
            possibleCollectables.Add(new Axe("OnlyAxe"));

            // One MagicWand
            possibleCollectables.Add(new MagicWand("OnlyMagicWand"));

            // Associate the CollectionBoard object to all the possible Collectables
            // using a foreach loop
            foreach (Collectable collectable in  possibleCollectables)
            {
                collectable.Board = board;
            }

            // Create an empty list to start collecting 
            List<Collectable> collected = new List<Collectable>();

            //Collect the items one-by-one in a foreach loop
            foreach (Collectable collectable in possibleCollectables)
            { 
                collectable.AddMe(collected);
            }

            Console.WriteLine("========================================");
            Console.WriteLine("==== All the Collected items ===========");
            Console.WriteLine("========================================");
            //Display all what was collected in a for each loop
            foreach (Collectable collectable in possibleCollectables)
            {
                collectable.Display();
            }
        }
    }
}
