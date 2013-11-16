using System;
using System.Collections.Generic;

namespace ProVision.Core
{
    public class EntityContainer : Entity
    {
        public List<Entity> EntityList { get; private set; }

        public EntityContainer(String newType, String newTitle) :
            base(newType, newTitle)
        {
            this.EntityList = new List<Entity>();
        }
    }
}
