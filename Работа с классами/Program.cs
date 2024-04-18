using System;

namespace Работа_с_классами
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Василий", 100, 5);
            player.ShowInfo();
        }
    }

    class Player
    {
        private string _name;
        private int _health;
        private int _level;

        public Player(string name, int health, int level)
        {
            _name = name;
            _health = health;
            _level = level;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"имя {_name} здоровье {_health} уровень {_level}");
        }
    }
}