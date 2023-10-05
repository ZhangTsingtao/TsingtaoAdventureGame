using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TsingtaoAdventureGame
{
    internal class Chamber
    {
        public Chamber Previous;
        public Chamber Left;
        public Chamber Right;

        public static int ChamberCount = 0;
        public int ID;
        public NPC ChamberNPC = new NPC();

        public Chamber()
        {
            ID = ChamberCount;
            ChamberCount++;
            Console.WriteLine("ID: " + ID);
        }

        public void Interact(HostileNPC a_hEnemy)
        {
            Console.WriteLine("You entered chamber " + ID);

            Console.WriteLine("You saw a blur figure ahead, do you interact with it?");
            if (GameManager.GetUserInput())
            {
                GameManager.Interact(a_hEnemy);
            }
        }

        public void BackToOrigin()
        {
            Console.WriteLine(ID);
            if (this.Previous != null)
            {
                this.Previous.BackToOrigin();
            }
            else
            {
                Console.WriteLine("Reached the root");
            }
        }

        public Chamber GoBack()
        {
            if (Previous != null) { return Previous; }
            else 
            {
                Console.WriteLine("No previous chamber. This is the start");
                return this;
            }
        }

        public Chamber GoLeft()
        {
            if (Left != null) { return Left; }
            else 
            {
                Console.WriteLine("No left chamber. You're still in this chamber");
                return this;
            }
        }
        public Chamber GoRight()
        {
            if (Right != null) { return Right; }
            else
            {
                Console.WriteLine("No right chamber. You're still in this chamber");
                return this;
            }
        }

        
        
    }
}
