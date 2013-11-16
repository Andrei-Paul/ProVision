using System;

namespace ProVision.Core
{
    public class Edition : EntityContainer
    {
        public Edition(String newTitle) :
            base("Edition", newTitle)
        {
        }
    }
}
