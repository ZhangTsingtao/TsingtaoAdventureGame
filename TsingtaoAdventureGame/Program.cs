namespace TsingtaoAdventureGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            string nameInput = "";
            while (nameInput == "")
            {
                Console.WriteLine("Type in your name: ");
                nameInput = Console.ReadLine();
            }

            Console.WriteLine("Hello, " + nameInput);
            Player.Name = nameInput;



            GenerateMap();



            HostileNPC hostileNPC = new HostileNPC("monster", 1);

            while (Player.HP > 0)
            {
                Console.WriteLine("Do you want to interact with it?");

                if (GameManager.GetUserInput())
                {
                    GameManager.Interact(hostileNPC);
                }
            }  
        }

        public static void GenerateMap()
        {
            Chamber cA = new Chamber();
            Chamber cB = new Chamber();
            Chamber cC = new Chamber();
            Chamber cD = new Chamber();
            Chamber cE = new Chamber();
            Chamber cF = new Chamber();
            Chamber cG = new Chamber();
            Chamber cH = new Chamber();

            cA.Left = cB; cB.Previous = cA;
            cA.Right = cC; cC.Previous = cA;

            cB.Left = cD; cD.Previous = cB;
            cB.Right = cE;cE.Previous = cB;
            
            cC.Left = cF; cF.Previous = cC;

            cD.Left = cG; cG.Previous = cD;

            cF.Right = cH; cH.Previous = cF;

            Console.WriteLine("");
            cH.BackToOrigin();

            Console.WriteLine("");

            HostileNPC hostileNPC = new HostileNPC();
            cA.Interact(hostileNPC);
        }
    }
}