using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        private int score;

        public Diamond(string Description, int score) : base(Description,score) 
        {
            this.score = score;
        }

        public override void Display()
        {
            Console.WriteLine("Diamond " + Description + " is diplayed");
        }
    }
}