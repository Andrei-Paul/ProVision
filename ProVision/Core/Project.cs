using System;

namespace ProVision.Core
{
    public class Project : EntityContainer
    {
        public Project(String newTitle) :
            base("Poject", newTitle)
        {
        }
    }
}
