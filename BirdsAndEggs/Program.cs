using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsAndEggs
{
    public interface IBird
    {
        Egg Lay();
    }

    public class Chicken: IBird
    {
        public Chicken()
        {
        }

        public Egg Lay()
        {
            return new Egg(() =>
            {
                return new Chicken();
            });
        }
    }

    public class Egg
    {
        private static IBird Bird
        {
            get; set;
        }

        private static bool IsItHatched
        {
            get; set;
        }

        public Egg(Func<IBird> createdBird)
        {
            Bird = createdBird.Invoke();
            IsItHatched = false;
        }

        public IBird Hatch()
        {
            if(!IsItHatched)
            {
                IsItHatched = true;
                return Bird;
            }            
            else
                throw new InvalidOperationException("This is egg was already hatched");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var chicken1 = new Chicken();
            var egg = chicken1.Lay();
            var childChicken = egg.Hatch();

            Console.ReadKey();
        }
    }
}
