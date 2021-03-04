// get the tracking casino thing to work
//add a labor method where you start with 50$ and can work to earn more




/*
 *  DOCUMENTATION:
 * 
 * Purpose: Two gambling simulators, a coin toss simulator and slot machine simulator.
 * Coin toss simulator generated a specified amount of random coin tosses and slot 
 * machine simulator creates three words and pays earnings depending on if two or three
 * are the same. Games are repeatable and there is a starting menu. 
 * 
 * Inputs: Menu = sanitized int for menu choice
 * Coin toss = sanitized int for coin flips
 * 
 * Slot machine = sanitized int for deposit amount
 * Play again= sanitized char for yes/no
 * 
 * Processing: Menu = choose a method based on input
 * Coin toss = flip random coins according to input
 * 
 * Slot machine = create three random words and calculate winnings at 2x for two words and 3x for three words
 * matching. 
 * 
 * Outputs: Menu = Calls other methods based on input number. 
 * Coin toss = Coin toss results (heads or tails) for each toss.
 * 
 * Slot machine = Earning amount for every spin.
 * 
 * Last modified: Feb 2021
 * 
 * Author: Azure Gallagher Michalak
 */


using System;
using System.Threading;
namespace UltimateCasino

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ultimate Casino! \n");
            int depositAmount = 50;
            Menu(ref depositAmount);
        }


        static void Menu(ref int depositAmount)
        {
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| Simulator Program Menu             |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("| 1. Work to make money              |");
            Console.WriteLine("| 2. Run Slot Machine                |");
            Console.WriteLine("| 3. Quit Program                    |");
            Console.WriteLine("|                                    |");
            Console.WriteLine("| Press a number then press enter.   |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine($" You have ${depositAmount}");
            int selection = 5;
            bool activatingProperly = false;
            while (activatingProperly == false)
            {
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    if (selection >= 1 && selection <= 4)
                    {
                        activatingProperly = true;
                    }
                    else
                    {
                        Console.WriteLine("Format incorrect. Try again.");
                    }
                }
                catch
                {
                    activatingProperly = false;
                    Console.WriteLine("Format incorrect. Try again.");
                }
            }

            if (activatingProperly == true)
            {
                switch (selection)
                {
                    case 1:
                        {
                            selection = 0;
                            CoinToss(depositAmount);
                            break;
                        }
                    case 2:
                        {
                            selection = 0;
                            SlotMachineLimited(ref depositAmount);
                            break;
                        }
                    case 3:
                        {
                            selection = 0;
                            Console.WriteLine($"Final money: {depositAmount}");
                            depositAmount = 0;
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Input Error, try again");
                            break;
                        }
                }
            }
        }


        static void CoinToss(int depositAmount)
        {
            Console.WriteLine("\n\n--------------------------------------");
            Console.WriteLine("|       Work      Simulator          |");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("This program simulates shoveling a hole for an hourly wage.\n");

            char numberTosses = 's';
            bool loopCoin = true;
            do
            {
                try
                {
                    Console.WriteLine("Press S once to dig a hole or press X to return to the main menu.");
                    numberTosses = char.Parse(Console.ReadLine());
                    if (numberTosses == 'x')
                        loopCoin = false;
                }
                catch
                {
                    Console.WriteLine("Format incorrect");
                }

                //this is the animation
                if (numberTosses == 's')
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Thread.Sleep(900);
                    Console.WriteLine("\\");
                    Console.WriteLine(" \\");
                    Console.WriteLine("  \\           0");
                    Console.WriteLine("   U");
                    Console.WriteLine("000");
                    Console.WriteLine(" 00");
                    Console.WriteLine("");
                    Thread.Sleep(900);
                    Console.WriteLine("--------D");
                    Console.WriteLine("             00");
                    Console.WriteLine("");
                    Console.WriteLine("0000");
                    Console.WriteLine(" 00");
                    Console.WriteLine("");
                    Thread.Sleep(800);
                    Console.WriteLine("\\");
                    Console.WriteLine(" \\");
                    Console.WriteLine("  \\          000");
                    Console.WriteLine("   U");
                    Console.WriteLine("0000");
                    Console.WriteLine("000");
                    Console.WriteLine("");
                    Thread.Sleep(700);
                    Console.WriteLine("--------D     0");
                    Console.WriteLine("             000");
                    Console.WriteLine("");
                    Console.WriteLine("00000");
                    Console.WriteLine("000");
                    Console.WriteLine("");
                    Thread.Sleep(600);
                    Console.WriteLine("\\");
                    Console.WriteLine(" \\            00");
                    Console.WriteLine("  \\          000");
                    Console.WriteLine("   U");
                    Console.WriteLine("00000");
                    Console.WriteLine("0000");
                    Console.WriteLine("");
                    Thread.Sleep(600);
                    Console.WriteLine("--------D     00");
                    Console.WriteLine("             0000");
                    Console.WriteLine("");
                    Console.WriteLine("00000");
                    Console.WriteLine("00000");
                    Console.WriteLine("");
                    Thread.Sleep(600);
                    Console.WriteLine("\\");
                    Console.WriteLine(" \\            000");
                    Console.WriteLine("  \\          0000");
                    Console.WriteLine("   U");
                    Console.WriteLine("000000");
                    Console.WriteLine("00000");
                    Console.WriteLine("");
                    Thread.Sleep(600);
                    Console.WriteLine("--------D    0000");
                    Console.WriteLine("             0000");
                    Console.WriteLine("");
                    Console.WriteLine("000000");
                    Console.WriteLine("000000");
                    Console.WriteLine("");
                    Thread.Sleep(600);
                    depositAmount += 5;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"You made $5. You have ${depositAmount}");
                }

            } while (loopCoin == true);

            Menu(ref depositAmount);
        }






      


        static void SlotMachineLimited(ref int depositAmount)
        {
            bool loopSlot = true;
            int thisRoundDepositAmount = 0;
            Console.WriteLine("-------------------------");
            Console.WriteLine("| Slot Machine Simulator |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("This program simulates a slot machine");

            while (depositAmount > 0)
            {
                Console.WriteLine($"Your money: ${depositAmount}");
                Console.WriteLine("Enter the amount to deposit into the slot machine: (press 0 to return to main menu)\n\n\n\n\n");
                do
                {
                    try
                    {

                        thisRoundDepositAmount = int.Parse(Console.ReadLine());
                        loopSlot = false;
                    }
                    catch
                    {
                        Console.WriteLine("Format incorrect");
                    }

                } while (loopSlot == true);
                //now we have deposit amount
                if (thisRoundDepositAmount == 0)
                {
                    Console.WriteLine($"Your final total: ${depositAmount}");
                    Menu(ref depositAmount);
                }
                else if (thisRoundDepositAmount <= depositAmount)
                {
                    depositAmount -= thisRoundDepositAmount;
                }
                else
                {
                    depositAmount = 0;
                    Console.WriteLine("Deposited too much. Try again.");
                }
                if (thisRoundDepositAmount > 0)
                {
                    Console.WriteLine($"Your money after deposit: ${depositAmount}\n");

                    Random slotNumbers = new Random();
                    int slot1 = slotNumbers.Next(0, 6);
                    int slot2 = slotNumbers.Next(0, 6);
                    int slot3 = slotNumbers.Next(0, 6);
                    Thread.Sleep(300);
                    switch (slot1)
                    {
                        case 0:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  ,.");
                                Console.WriteLine(" / |");
                                Console.WriteLine("OO O ");
                                Console.WriteLine("Cherries");
                                break;
                            }
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" _  ");
                                Console.WriteLine("(0)_");
                                Console.WriteLine("  (0)");
                                Console.WriteLine("Oranges");
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("()");
                                Console.WriteLine("  ()");
                                Console.WriteLine("()");
                                Console.WriteLine("Plums");
                                break;
                            }
                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" __");
                                Console.WriteLine("|  |");
                                Console.WriteLine("/__\\");
                                Console.WriteLine("Bells");
                                break;
                            }
                        case 4:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("//0\\\\");
                                Console.WriteLine("|000|");
                                Console.WriteLine("\\\\0//");
                                Console.WriteLine("Melons");
                                break;
                            }
                        case 5:
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("_____");
                                Console.WriteLine("|BAR|");
                                Console.WriteLine("-----\n");
                                break;
                            }
                    }
                    Console.WriteLine("\n");
                    Thread.Sleep(300);
                    switch (slot2)
                    {
                        case 0:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  ,.");
                                Console.WriteLine(" / |");
                                Console.WriteLine("OO O ");
                                Console.WriteLine("Cherries");
                                break;
                            }
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" _  ");
                                Console.WriteLine("(0)_");
                                Console.WriteLine("  (0)");
                                Console.WriteLine("Oranges");
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("()");
                                Console.WriteLine("  ()");
                                Console.WriteLine("()");
                                Console.WriteLine("Plums");
                                break;
                            }
                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" __");
                                Console.WriteLine("|  |");
                                Console.WriteLine("/__\\");
                                Console.WriteLine("Bells");
                                break;
                            }
                        case 4:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("//0\\\\");
                                Console.WriteLine("|000|");
                                Console.WriteLine("\\\\0//");
                                Console.WriteLine("Melons");
                                break;
                            }
                        case 5:
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("_____");
                                Console.WriteLine("|BAR|");
                                Console.WriteLine("-----\n");
                                break;
                            }
                    }
                    Console.WriteLine("\n");
                    Thread.Sleep(300);
                    switch (slot3)
                    {
                        case 0:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  ,.");
                                Console.WriteLine(" / |");
                                Console.WriteLine("OO O ");
                                Console.WriteLine("Cherries");
                                break;
                            }
                        case 1:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(" _  ");
                                Console.WriteLine("(0)_");
                                Console.WriteLine("  (0)");
                                Console.WriteLine("Oranges");
                                break;
                            }
                        case 2:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("()");
                                Console.WriteLine("  ()");
                                Console.WriteLine("()");
                                Console.WriteLine("Plums");
                                break;
                            }
                        case 3:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" __");
                                Console.WriteLine("|  |");
                                Console.WriteLine("/__\\");
                                Console.WriteLine("Bells");
                                break;
                            }
                        case 4:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("//0\\\\");
                                Console.WriteLine("|000|");
                                Console.WriteLine("\\\\0//");
                                Console.WriteLine("Melons");
                                break;
                            }
                        case 5:
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("_____");
                                Console.WriteLine("|BAR|");
                                Console.WriteLine("-----\n");
                                break;
                            }
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    if (slot1 == slot2 && slot2 == slot3)
                    {
                        Console.WriteLine("\nThree match");
                        depositAmount += (thisRoundDepositAmount * 3);
                        Console.WriteLine($"\nYou won: {thisRoundDepositAmount * 3}");
                    }
                    else if (slot1 == slot2 || slot2 == slot3 || slot1 == slot3)
                    {
                        Console.WriteLine("\nTwo match");
                        depositAmount += (thisRoundDepositAmount * 2);
                        Console.WriteLine($"\nYou won: {thisRoundDepositAmount * 2}");
                    }
                    else
                    {
                        Console.WriteLine("\nYou win: 0");
                    }
                }
            }
            if (depositAmount <= 0)
            {
                Console.WriteLine("Out of cash. Goodbye.");
            }


            /* Total amount deposited:  $1,300.00Total amount won:  $2,600.00Net gain/loss total:  $1,300.0 */

        }




    }
}
