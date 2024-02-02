using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Tool : Collectable 
    {
        public Tool(string Description) : base(Description)
        {

        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);

            Console.WriteLine(Description + " Collected Congrats!!");
            DoAction();
        }
        public virtual void DoAction() { 
        }


    }
}
