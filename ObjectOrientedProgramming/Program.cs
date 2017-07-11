using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called INSTANTIATING (creating a new instance)
            //An object needs to be instantiated before it can be used
            //All objects of a specific type are created from the same template -CLASS
            //All objects from a class will have the same number and type of states, BUT....
            //each instance can have its own unique values.

            //the format we use to instantiate an object looks like this:
            //ClassName objectName = new ClassName();
            //Cat firstCat = new Cat();

            //firstCat.Name = "Mittens";
            ////Console.WriteLine(firstCat.Age);

            //Cat secondCat = new Cat("Oz", 3, "orange and white");
            //secondCat.Name = "Ozzy";
            //Console.WriteLine(secondCat.Name);
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat();




            //To create a new object, we use a special method called a CONSTRUCTOR

            //Thinking about object in real life, create three examples of objects
            //your objects should have 5 states(characteristics) and five behaviors.
            //example: Car                    bike                   phone
            //       color-fast            color-fast                color-dials
            //       size- moves           size-moves                size-records
            //       weight- parks         weight-moves foward       weight-rings
            //       doors- moves foward   pedals-moves back         keyboard-sends
            //       tires-moves back      tires-rides on one wheel  screen size-receives


            Superhero firstHero = new Superhero();
            //firstHero.StrengthLevel = 100;
            //firstHero.HasCape = true;

            //firstHero.BattleNemesis();
            //Console.WriteLine(firstHero.HasCape);
            //Console.WriteLine(firstHero.StrengthLevel);

            Superhero secondHero = new Superhero("Super Jerome");
            //Console.WriteLine(secondHero.StrengthLevel);

            //secondHero.AllyGained();
            //Console.WriteLine(secondHero.StrengthLevel);

            Superhero thirdHero = new Superhero("Doctor Evil", "black unitard", "the Best", 1000, true);

            thirdHero.BattleNemesis();
            Console.WriteLine("Oh no! Now my costume is " + thirdHero.Costume);
            Console.WriteLine("And now my strength has diminished to " + thirdHero.StrengthLevel);

               





















        }
    }
}
