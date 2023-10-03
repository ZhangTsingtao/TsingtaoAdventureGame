using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingtaoAdventureGame
{
    internal class HostileNPC : NPC
    {
        public HostileNPC() { }
        public HostileNPC(string a_sName, int a_nLevel) : base(a_sName, a_nLevel)
        {

        }

        public override void Interact(Player a_pPlayer)//polymorphism
        {
            base.Interact(a_pPlayer);
            Console.WriteLine("It's a hostile enemy!");
            Console.WriteLine("----Fight!----");

            if (a_pPlayer.Damage > m_nDefense)
            {
                int damage = a_pPlayer.Damage - m_nDefense;
                m_nHP -= (a_pPlayer.Damage - m_nDefense);
                Console.WriteLine("Enemy is hurt by " + damage + "points");
                Console.WriteLine("Its HP is " +  m_nHP);
            }
            else
            {
                Console.WriteLine("Enemy is too powerful, it's unharmed!");
            }

            a_pPlayer.Fight(this);

            Console.WriteLine("Enemy");

        }

    }
}
