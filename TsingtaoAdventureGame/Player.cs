using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingtaoAdventureGame
{
    internal class Player
    {
        private string m_sName = "Unamed";
        private int m_nLevel = 0;
        private int m_nHP = 100;
        public int Damage = 0;
        private int m_nDefense = 0;

        public Player(string a_sName) 
        { 
            m_sName = a_sName;
        }
        public int HP { get { return m_nHP; } set { m_nHP = value; } }

        public void Fight(HostileNPC a_hEnemy) 
        {
            if (a_hEnemy.Damage > m_nDefense)
            {
                int damage = a_hEnemy.Damage - m_nDefense;
                m_nHP -= (a_hEnemy.Damage - m_nDefense);
                Console.WriteLine("You're damaged by " + damage);
                Console.WriteLine("Your HP is " +  m_nHP);
            } 
        }
    }
}
