using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProVision.Core
{
    public class Person : Entity
    {
        public Person(String newName) :
            base("Person", newName)
        {
        }
    }
}
