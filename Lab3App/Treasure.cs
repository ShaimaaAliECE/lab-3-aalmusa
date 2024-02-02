using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure :Collectable
    {
        private int score;

        public Treasure(string Description, int score) : base(Description)
        {
            this.score = score;
        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);

            Console.WriteLine(Description+ " Collected Congrats!!");
            UpdateTotalScore();
        }
        public virtual void UpdateTotalScore() 
        {
            Board.TotalScore += score;

            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }

    }
}
