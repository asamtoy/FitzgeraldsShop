// Brief: create a shop for Fitzgerald of things he likes, with an inventory.  
//Then, make a menu for running the shop, adding things or selling them.  
//Always return to the menu at the beginning until you quit 

using System;

namespace FitzgeraldsShop
{

    class Program
    {
        static void Main(string[] args)
        {

            //Initialize the program

            string sellItemName;
            byte selection;
            int balance = 1000;
            Sellable[] inventory = new Sellable[10];

            {
                inventory[0] = new Sellable();
                inventory[1] = new Sellable();
                inventory[2] = new Sellable();
                inventory[3] = new Sellable();
                inventory[4] = new Sellable();
                inventory[5] = new Sellable();
                inventory[6] = new Sellable();
                inventory[7] = new Sellable();
                inventory[8] = new Sellable();
                inventory[9] = new Sellable();

                inventory[0].Name = "Fish";
                inventory[0].Price = 1;
                inventory[1].Name = "Biscuits";
                inventory[1].Price = 5;
                inventory[2].Name = "Library";
                inventory[2].Price = 200;
                inventory[3].Name = "Carrots";
                inventory[3].Price = 500;
                inventory[4].Name = "Music";
                inventory[4].Price = 0;
                inventory[5].Name = "Health and Safety";
                inventory[5].Price = 0;
                inventory[6].Name = "Beer";
                inventory[6].Price = 3;
                inventory[7].Name = "Pickle Sandwiches";
                inventory[7].Price = 2;
        };
            //Welcome

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome to Fitzgerald's Shop of Favourite Things!");
                Console.WriteLine("Please select from the following options:");
                Console.WriteLine("Press 1 to view the inventory;");
                Console.WriteLine("Press 2 to add something to the inventory;");
                Console.WriteLine("Press 3 to sell something.");
                Console.WriteLine("Press 4 to view your balance.");
                Console.WriteLine("Press 5 to view exit.");

                var entry = Console.ReadLine();
                selection = byte.Parse(entry);

                //Catch non-acceptable entries
                //LATER: Figure out how to exclude letters and other non-number characters

                if (selection != 1 && selection != 2 && selection != 3 && selection != 4 && selection != 5)
                {
                    Console.WriteLine("Please enter a valid number 1-4...");
                }

                if (selection == 1 || selection == 2 || selection == 3 || selection == 4 || selection == 5)
                {
                    

                //View Inventory:
                    {
                        if (selection == 1)
                            {
                                for (int i = 0; i < inventory.Length; i++)
                                    if (inventory[i] != null)
                                        {
                                Console.WriteLine($"Name: {inventory[i].Name}, Price: {inventory[i].Price}");
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
                                        Console.WriteLine("Please enter an item name to add");
                                        var newItemName = Console.ReadLine();
                                        Console.WriteLine("Please enter an item price to add");
                                        var newItemPrice = Console.ReadLine();
                                        for (int i = 0; i < inventory.Length; i++)
                                            {
                                                if (inventory[i] == null)
                                                    {
                                        inventory[i].Name = newItemName;
                                        inventory[i].Price = Convert.ToInt32(newItemPrice);
                                        balance -= Convert.ToInt32(newItemPrice);
                                                    break;
                                                    }   
                                            }
                                Console.WriteLine($"{newItemName} has been added to your inventory for £{newItemPrice}!");
                                    }
                    
                            }

                    //Extension: loop through the array; when there is a 0, insert the item, then stop looping.  
                    //If there are no more zeroes, say, "sorry, the inventory is full!"
                    //If you can, add numbers to the item; inventory location + 1?

                    //3 Sell something 
                        if (selection == 3)
                            {
                                Console.WriteLine("Please type in the item to sell:");
                                sellItemName = Console.ReadLine();
                                
                                for (int i = 0; i < inventory.Length; i ++)
                                {
                                    if (inventory[i].Name == sellItemName)
                                        {
                                    balance += inventory[i].Price;
                                            inventory[i] = null;
                                            break;
                                        }
                                }
                                Console.WriteLine($"{sellItemName} has been sold.");
                            }

                        if (selection == 4)
                        {
                            Console.WriteLine($"Your current balance is £{balance}.");
                        break;

                        }

                        if (selection == 5)
                        {
                            Console.WriteLine("You're amazing! Goodbye!");
                            break;
                        }
                    }
                }

            }
            while (selection != 5);                           

        }
    }
}

