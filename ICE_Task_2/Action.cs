/*
 * Marcus McDowall Marcussmcdowall@gmail.com
 * ST10356369
 * PROG6211
*/

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
            //initializing the filepath to null and starting the loop
            string filepath = null;
            while (true)
            {
                Console.WriteLine("Which file would you like to play: ");
                //calling the print file option method to display the files so text can be green or not
                PrintFileOption(1, "FileOne");
                PrintFileOption(2, "FileTwo");
                PrintFileOption(3, "FileThree");
                Console.WriteLine("4: Exit");
                int userchc = int.Parse(Console.ReadLine());

                //switch statement to determine which file to play
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

                //creating the sound player and playing the file
                SoundPlayer player = new SoundPlayer(filepath);
                //locating and playing the file
                player.SoundLocation = filepath;
                player.Play();
                //letting the user control when to continue
                Console.ReadLine();
            }
        }
        //method to print the file options
        private void PrintFileOption(int optionNumber, string fileName)
        {
            //if the file has been played it will be green
            if (playedFiles.Contains(optionNumber))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine($"{optionNumber}: {fileName}");
            //resetting the color
            Console.ResetColor();
        }
    }
}
//======================================== EOF ========================================//