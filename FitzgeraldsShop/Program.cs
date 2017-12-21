using System;

namespace FitzgeraldsShop
{
    class Program
    {
        static void Main(string[] args)
        {

            // Brief: create a shop for Fitzgerald of things he likes, with an inventory.  
            //Then, make a menu for running the shop, adding things or selling them.  
            //Always return to the menu at the beginning until you quit 

            //Initialize the program

            string entry, newItem, sellItem;
            byte selection;
            String[] inventory = new string[50];
            inventory[0] = "Fish";
            inventory[1] = "Biscuits";
            inventory[2] = "Library";
            inventory[3] = "Carrots";
            inventory[4] = "Music";
            inventory[5] = "Health and Safety";
            inventory[6] = "Beer";
            inventory[7] = "Pickle Sandwiches";

            //Welcome

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Fitzgerald's Shop of Favourite Things!");
                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("Press 1 to view the inventory;");
                Console.WriteLine("Press 2 to add something to the inventory;");
                Console.WriteLine("Press 3 to sell something.");
                Console.WriteLine("Press 4 to exit.");

                entry = Console.ReadLine();
                selection = byte.Parse(entry);

                //Catch non-acceptable entries
                //LATER: Figure out how to exclude letters and other non-number characters

                if (selection != 1 && selection != 2 && selection != 3 && selection != 4)
                {
                    Console.WriteLine("Please enter a valid number 1-4...");
                }

                if (selection == 1 || selection == 2 || selection == 3 || selection == 4)
                {
                    

                //View Inventory:
                    {
                        if (selection == 1)
                            {
                                for (int i = 0; i < inventory.Length; i++)
                                    if (inventory[i] != null)
                                        {
                                        Console.WriteLine(inventory[i]);
                                        }
                            }

                    //Option menu

                    ////2 add to inventory
                        if (selection == 2)
                            {
                                if (inventory[inventory.Length - 1] != null)
                                    {
                                        Console.WriteLine("Sorry, we are unable to add items at this time");
                                    }    
                                if (inventory[inventory.Length - 1] == null)
                                    {
                                        Console.WriteLine("Please enter an item to add");
                                        newItem = Console.ReadLine();
                                        for (int i = 0; i < inventory.Length; i++)
                                            {
                                                if (inventory[i] == null)
                                                    {
                                                    inventory[i] = newItem;
                                                    break;
                                                    }   
                                            }
                                        Console.WriteLine($"{newItem} has been added to your inventory!");
                                    }
                    
                            }

                    //Extension: loop through the array; when there is a 0, insert the item, then stop looping.  
                    //If there are no more zeroes, say, "sorry, the inventory is full!"
                    //If you can, add numbers to the item; inventory location + 1?

                    //3 Sell something 
                        if (selection == 3)
                            {
                                Console.WriteLine("Please type in the item to sell:");
                                sellItem = Console.ReadLine();
                                for (int i = 0; i < inventory.Length; i ++)
                                {
                                    if (inventory[i] == sellItem)
                                        {
                                            inventory[i] = null;
                                            break;
                                        }
                                }
                                Console.WriteLine($"{sellItem} has been taken out of your inventory.");
                            }
                    //Select an item to sell
                    //Remove it from the array
                    //If you can, at the end, add an account balance, and prices for each item; remove from array, add price to the balance

                    //else Console.WriteLine("Please enter 1-4");
                        if (selection == 4)
                        {
                        Console.WriteLine("You're amazing! Goodbye!");
                        break;

                        }
                    }
                }
            }
                while (selection != 4);                           
        }
    }
}

