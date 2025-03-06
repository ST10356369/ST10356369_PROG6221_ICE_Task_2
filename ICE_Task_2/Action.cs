using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_2
{
    internal class Action
    {
        private HashSet<int> playedFiles = new HashSet<int>();

        public Action()
        {
        }

        public void Play()
        {
            string filepath = null;
            while (true)
            {
                Console.WriteLine("Which file would you like to play: ");
                PrintFileOption(1, "FileOne");
                PrintFileOption(2, "FileTwo");
                PrintFileOption(3, "FileThree");
                Console.WriteLine("4: Exit");
                int userchc = int.Parse(Console.ReadLine());

                switch (userchc)
                {
                    case 1:
                        Console.WriteLine("Playing FileOne");
                        filepath = "FileOne.wav";
                        playedFiles.Add(1);
                        break;
                    case 2:
                        Console.WriteLine("Playing FileTwo");
                        filepath = "FileTwo.wav";
                        playedFiles.Add(2);
                        break;
                    case 3:
                        Console.WriteLine("Playing FileThree");
                        filepath = "FileThree.wav";
                        playedFiles.Add(3);
                        break;
                    case 4:
                        Console.WriteLine("Exiting");
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                SoundPlayer player = new SoundPlayer(filepath);
                player.SoundLocation = filepath;
                player.Play();
                Console.ReadLine();
            }
        }

        private void PrintFileOption(int optionNumber, string fileName)
        {
            if (playedFiles.Contains(optionNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"{optionNumber}: {fileName}");
            Console.ResetColor();
        }
    }
}