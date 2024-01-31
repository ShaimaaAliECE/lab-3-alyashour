using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        protected string Description;
        public CollectionBoard Board;

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }
        
        public abstract void Display();
    }
}