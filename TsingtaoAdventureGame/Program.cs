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
            
            Player player = new Player(nameInput);

            NPC nPC = new NPC();

            NPC nPC2 = new NPC("Old Lady");


            HostileNPC hostileNPC = new HostileNPC("monster", 10);

            hostileNPC.Interact(player);


        }
    }
}