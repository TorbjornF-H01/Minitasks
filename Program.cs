// ______________________________________________🍕🍕MiniTasks🍕🍕__________________________________________________
//                                                😋😋 😋😋
//____________________________________________🍕🍕MiniTasks🍕🍕__________________________________________________



using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // Had to put this in to get it to show emojis in console
        // Task 1:

        Console.WriteLine("Please enter your name:"); //Asks the user to enter their name
        string userName = Console.ReadLine();         //Stores the name
        Console.WriteLine("Salutations, " + userName + "!👍");//Prints the name with a greeting!

        //Task 2: Age Verification and Terms of Service Agreement Program

        Console.WriteLine("Please enter your age:");  //Asks the user to enter age
        int userAge = Convert.ToInt32(Console.ReadLine()); //Convert string to int, user input number
        //basic if / else 
        if (userAge < 18)
        {
            Console.WriteLine("You must be 18 years old to use this service.");
        }
        else
        {
            Console.WriteLine("Do you agree with the terms of service? yes/no");
            string userResponse = Console.ReadLine();

            if (userResponse == "no")
            {
                Console.WriteLine("You must agree to the terms of service to continue.🤬");
            }
            else if (userResponse == "yes")
            {
                Console.WriteLine("Thank you!😁");
                Console.WriteLine("Name: " + userName);
                Console.WriteLine("Age: " + userAge);
                Console.WriteLine("Accepted TOS: yes");
            }
            else
            {
                Console.WriteLine("Invalid response.😤 Please restart the program and try again.🫠");
            }

            // Task 3: Variable Names and Types🔢

            Console.WriteLine("Enter the name of the grocery item:"); // Asks for a grocery item stores the item in inventoryItem for later use
            string inventoryItem = Console.ReadLine();
            Console.WriteLine("Enter the quantity:"); // Asks for quantity stores in itemQuantity
            string itemQuantity = Console.ReadLine();
            Console.WriteLine("Enter the weight in kilograms:"); // Asks for the wheight  stores in weightKilo
            string weightKilo = Console.ReadLine();
            Console.WriteLine("Enter the price per unit:"); // Asks for the price per unit stores in unitPrice
            string unitPrice = Console.ReadLine();
            Console.WriteLine($"Item: {inventoryItem}, Quantity: {itemQuantity}, Weight: {weightKilo} kg, Price: ${unitPrice}"); //Prints all the stored values 

            // Task 4: Simple Calculator Program🧮


            // asks for the first number 🔢
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // asks for the operator ➕➖➗✖️
            Console.Write("Enter the math operator symbol (+, -, /, *): ");
            char operation = Console.ReadKey().KeyChar; //user input
            Console.WriteLine();  // Move to the next line

            // asks for the second number 🔢
            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // perform the operation and display the result
            double result;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.🤬");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.🫠");
                    return;
            }

            // Displaying the result 🥳🎉🎊
            Console.WriteLine($"The result of {num1} {operation} {num2} is {result}.👏");







        }
    }
}