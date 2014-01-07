using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleForGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            const Int32 MAX_GUESSES = 10; //Maximum number of permitted guesses by user
            const Int32 MAX_NUMBER = 100; //Maximum number to be chosen randomly
            Random rnd = new Random();
            String sUserName = String.Empty;
            String SUserResp = String.Empty;
            Int32 iMyNum = 0;
            Int32 iGuess = 0;
            Boolean bFound = false;

            //Obtain the user's name and store it
            Console.Write("\nWelcome, knave. Who goeth there? ");
            sUserName = Console.ReadLine();

            //Tell the user the limit to the computer's number
            Console.WriteLine("\nI greet thee, " + sUserName + "!");

            //Tell the user the limit of the guesses they get
            Console.WriteLine("\nIn the name of His Majesty the King, I grant thee " + MAX_GUESSES
                + "\nguesses in which thou must determine my number, which doth be under " + MAX_NUMBER
                + ".");
            //Determine the number to be guessed
            iMyNum = rnd.Next(MAX_NUMBER);

            //Start the loop for his guesses
            for (Int32 i = 0; i < MAX_GUESSES; i++)
            {
                //Obtain a guess
                Console.Write("\nGrant me thy guess, knave...I mean, " + sUserName + "! ");
                SUserResp = Console.ReadLine();
                iGuess = Convert.ToInt32(SUserResp);

                //Check guess against computer's number and give appropriate response
                if (iMyNum < iGuess)
                {
                    Console.Write("\nThou fool!! Thy number is aloft (higher) than mine! \nPress enter to makest another guess. ");
                    Console.ReadLine();
                }
                else if (iMyNum > iGuess)
                {
                    Console.Write("\nThou fool!! My number tramples thine underfoot (lower)! \nPress enter to makest another guess. ");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("\nI yield to thy superiority, Kna-....your Highness!");
                    Console.ReadLine();
                }
                //If guessed number is accurate, exit the loop
                if (iMyNum == iGuess)
                {
                    bFound = true;
                    break;
                }
            }

            if (bFound)
            {
                Console.WriteLine("\nI congratulate thee! My thanks be to thee for thy participations!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nI bask in my superiority! Yield, knave! \nMy number wast "
                    + iMyNum.ToString() + ".");
                Console.ReadLine();
            }
        }
    }
}
