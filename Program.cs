using System;
using System.Collections.Generic;

namespace Rooms
{
    class Generator
    {
        public Game Generate()
        {
            return new Game
            {
                Player = new Player
                {
                    HitPoints = 8,
                    Strength = 5
                },
                CurrentRoom = new Room
                {
                    Description = "You're in a small closet.",
                    Exits = new List<Exit> {
                        new Exit {
                            Description = "There is a door that leads out of the closet.",
                            Option = "Take the door and leave the closet.",
                            Room = new Room {
                                Description = "You find yourself in a decrepit bedroom.",
                                Monsters = new List<Monster> {
                                    new Monster {
                                        Name = "Zombie Kid",
                                        Description = "A once sweet kid who's clearly turned into a murderous Zombie.",
                                        Strength = 3,
                                        HitPoints = 3
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }

    class Game
    {
        public Room CurrentRoom { get; set; }
        public Player Player { get; set; }

        public void Play()
        {
            Console.WriteLine("You win!");
        }
    }

    class Exit
    {
        public string Description { get; set; }
        public string Option { get; set; }
        public Room Room { get; set; }
    }

    class Room
    {
        public string Description { get; set; }
        public List<Monster> Monsters { get; set; } = new List<Monster>();
        public List<Exit> Exits { get; set; } = new List<Exit>();
    }

    class Player
    {
        public int HitPoints { get; set; }
        public int Strength { get; set; }
    }

    class Monster
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Generator().Generate().Play();
        }
    }
}
