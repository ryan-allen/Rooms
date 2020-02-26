using System;

namespace Rooms
{

    class Generator
    {
        public Game Generate() => new Game();
    }

    class Game
    {
        public void Play()
        {
            Console.WriteLine("You win!");
        }
    }

    class Room
    {

    }

    class Player
    {

    }

    class Monster
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            new Generator().Generate().Play();
        }
    }
}
