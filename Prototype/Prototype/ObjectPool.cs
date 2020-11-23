using System.Collections.Generic;

namespace Prototype
{
  

    class ObjectPool
    {
        Dictionary<Type, Player> presets;


        public ObjectPool()
        {
            presets = new Dictionary<Type, Player>();

            presets.Add(Type.WARRIOR, new Player()
            {
                Name = "Axiles",
                Surname = "Warrior",
                Age = 25
            });
            presets.Add(Type.PERSON, new Player()
            {
                Name = "Vaqif",
                Surname = "Eliyev",
                Age = 50
            });

        }

        public Player this[Type cls]
        {
            get { return presets[cls].Clone() as Player; }
            //set { presets[cls]=value; }
            
        }

    }



}
