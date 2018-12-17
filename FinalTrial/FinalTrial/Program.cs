using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTrial
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero();
            Hero myOtherHero = new Hero("Flash", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman", "All bad people", "Amazonian", "Stength, Speed, Fly");


            myOtherHero.ChargePower(10);
            myOtherHero.Investigate();
            myOtherHero.FightCrime("home");
            myOtherHero.Fly();
            myOtherHero.Climb(7);
            myOtherHero.Craft("cashmere", 6);
           
           
           


            thirdHero.ChargePower(47);
            thirdHero.Investigate();
            thirdHero.FightCrime("home");
            thirdHero.Fly();
            thirdHero.Climb(7);
            thirdHero.Craft("cashmere", 6);
            
           
           













            /*
                Problem 7:
                Each Hero must:
                 - ChargePower (as much as you want)
                 - Investigate
                 - FightCrime (at least one must win. at least one must not win)
                 - Fly (at least one superhero should be able to fly)
                 - Climb
                 */
        }
    }
}
