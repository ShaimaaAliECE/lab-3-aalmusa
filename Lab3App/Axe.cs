using System;

namespace Lab3App
{
    internal class Axe : Tool
    {

        public Axe(string Description) : base(Description)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is diplayed");
        }
        public override void DoAction()
        {

            Console.WriteLine("Axe is used");
        }
    }
}