using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int score;
        private int value;

        public Coin(string Description, int score, int value) : base(Description, score)
        {
            this.score = score;
            this.value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);

            Console.WriteLine(Description + " Collected Congrats!!");
            UpdateTotalValue();
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += value;

            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

    }
}