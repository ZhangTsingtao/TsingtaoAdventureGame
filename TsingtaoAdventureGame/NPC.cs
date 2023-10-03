﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TsingtaoAdventureGame
{
    //This is the base class, it has two subclasses:
    //HostileNPC and FriendlyNPC
    internal class NPC 
    {
        protected string m_sName = "Unamed";
        protected int m_nLevel = 0;
        protected int m_nHP = 100;
        public int Damage = 0;
        protected int m_nDefense = 0;

        public NPC() { }
        public NPC(string a_sName)
        {
            m_sName = a_sName;
            Init();
        }
        public NPC(string a_sName, int a_nLevel)
        {
            m_sName = a_sName;
            m_nLevel = a_nLevel;
            Init();

        }
        public void Init() 
        {
            m_nHP = 100;
            Damage += m_nLevel * 5;
            m_nDefense += m_nLevel * 3;
            Print();
        }

        //polymorphism
        public virtual void Interact(Player a_pPlayer)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Interact with " + m_sName);
        }

        public void Print()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Name: " + m_sName);
            Console.WriteLine("Level: " + m_nLevel);
            Console.WriteLine(" ");
        }

        public int HP { get { return m_nHP; } set { m_nHP = value; } } 
    }
}
