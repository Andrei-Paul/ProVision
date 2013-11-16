using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProVision.Core
{
    public class Entity
    {
        public static UInt64 NumberOfEntities { get; private set; }
        private static Object NumberOfEntities_Lock = new Object();

        public readonly UInt64 ID = 0;

        public String Type { get; private set; }
        public String Title { get; private set; }
        public String Content { get; private set; }

        public List<Entity> Predecesors { get; private set; }
        public List<Entity> Succesors { get; private set; }

        public Entity(String newType, String newTitle)
        {
            lock (NumberOfEntities_Lock)
            {
                this.ID = NumberOfEntities;
                Entity.NumberOfEntities++;
            }

            this.Type = newType;
            this.Title = newTitle;

            this.Predecesors = new List<Entity>();
            this.Succesors = new List<Entity>();
        }
    }
}
