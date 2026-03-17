using System;
using System.Collections.Generic;
using System.Text;
using Main;
namespace Playerhealth
{
    internal class Player
    {
        public int Health { get; private set; }
        public Player() 
        {
            Health = 100;
        }
        public void TakeDamage(int amount)
        {
            if ((Health - amount)<= 0)
            {
                Health = 0;
                Console.WriteLine("Player defeated");
                
            }
            else
            {
            Health -= amount;
                Console.WriteLine($"Health: {Health}");
            }
        }
        public void Heal(int amount)
        {
            if ((Health + amount) >= 100)
            {
                Health = 100;
                Console.WriteLine($"Health: {Health}");
            }
            else
            {
                Health += amount;
                Console.WriteLine($"Health: {Health}");
            }
        }
    }
}
