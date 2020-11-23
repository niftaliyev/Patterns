using System;

namespace Prototype
{
    class Player : ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }



        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} Age: {Age}"; 
        }


        public object Clone()
        {
            return MemberwiseClone();
        }

    }
}
