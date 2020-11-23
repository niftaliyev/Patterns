using System;

namespace Prototype
{
  
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool objectPool = new ObjectPool();
            Player player = objectPool[Type.PERSON];

            
            Console.WriteLine(player);

        }
    }
}
