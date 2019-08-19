using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Game
    {
        //variables declared outside of functions can be 
        //used as paramaters for functions.
        int numberOne = 10;
        int numberTwo = 200;

        //int playerHealth = 100;
        //int monsterDamage = 30;

        //Start is the name of the function;
        //void means it doesn't return any values;
        //public means other classes / files cn use this function.

        public void Start()
        {
            int biggestNumber = numberTwo;

            Console.Write("of " + numberOne + " and" + numberTwo +
                " the biggest number is " + biggestNumber);
            Console.ReadKey();


            //Console.WriteLine("My game has begun!");
            //Console.ReadKey();
            //MonsterEncounter();
            //MonsterAttacks(monsterDamage * 2);
            //MonsterAttacks(monsterDamage);
            //MonsterAttacks(monsterDamage * 3);

        }

        //no private or public statement means that function is private;

        int ReturnBiggestNumber(int first, int second)
        {
            if(first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        
        //private void MonsterEncounter()
        //{
        //    Console.WriteLine("Avicious monster appears!");
        //    Console.ReadKey();
        //}
        //private void MonsterAttacks(int damage)
        //{            
        //    playerHealth -= damage;
        //    Console.WriteLine("The monster attacks you for " + damage +
        //        " points of damage. You have " + playerHealth + " health left.");
        //    Console.ReadKey();
        //}
    }
}
