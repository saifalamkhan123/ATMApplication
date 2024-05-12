

namespace atmApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

          ///  <summary>    // This is xml tag.......

            // This is my ATM bank --- Learned in Aptech with Shahraiz sir --- //
            

          ///  </summary>

            int amount = 20000;
            int pin = 1122;
            int current;

            Console.WriteLine("Welcome to ATM");
            Console.WriteLine("===============");
            Console.WriteLine("   ");

            Console.Write("Enter pin for security :\t");
            int securityPin = int.Parse(Console.ReadLine());

            Console.WriteLine();


            if (pin == securityPin)
            {

                Console.WriteLine("1. Enter check your balance");
                Console.WriteLine("2. Enter amount to draw cash");
                Console.WriteLine("3. Enter amount to deposit");
                Console.WriteLine("4. Enter new Pin for change");
                Console.WriteLine("***** Enter number for choice *****");

                Console.WriteLine("  ");

                Console.Write("Enter any number to use ATM :\t");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {

                    case 1:
                                             
                            Console.WriteLine("your balance amount is : " + amount);
                       
                        break;

                    case 2:
                        Console.Write("Enter amount for draw cash :\t");
                        int drawCash = int.Parse(Console.ReadLine());

                        
                        if (drawCash <= amount)
                        {
                            current = amount - drawCash;
                            Console.WriteLine("Current amount is :" + current);
                        }
                        else
                        {
                            Console.WriteLine("Your amount is exceeding from your balance");
                        }
                        break;

                        case 3:

                        Console.Write("Enter amount to deposit cash :\t");
                        int depositCash = int.Parse(Console.ReadLine());

                        int depositAmount = amount + depositCash;
                        Console.WriteLine("Your total amount is deposited : " + depositAmount + " Rs.");
                        break;

                        case 4:
                        Console.Write("Enter old pin for verify :\t");
                        int oldPin = int.Parse(Console.ReadLine());
                      
                        if (pin==oldPin)
                        {
                            Console.Write("Enter new pin number :\t");
                            int newPin = int.Parse(Console.ReadLine());

                            Console.WriteLine("Your pin has been changed....");

                        }
                        else
                        {
                            Console.WriteLine("Try Again");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }

            }
            else
            {

                Console.WriteLine("You have no authorized");

            }

            Console.ReadLine();
        }
    }
}