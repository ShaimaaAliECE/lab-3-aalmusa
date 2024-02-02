using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        internal CollectionBoard Board;
        protected string Description;

        public Collectable(string Description) {
            this.Description = Description;
        }
        
        public virtual void AddMe(List<Collectable> collectables)
        {}
        public virtual void Display() { }

      
    }
}