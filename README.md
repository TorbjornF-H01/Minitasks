C# - minitasks

Due Mar 18
These tasks are designed to help you practice and understand the fundamentals of C# programming, including user input, conditional logic, basic arithmetic operations, and variable management. As you work through these exercises, keep the following key points in mind:
Always use descriptive and meaningful names for your variables. This practice makes your code more readable and understandable, not only for others but also for yourself when you return to your code after some time.
Make a habit of commenting on your code. Use single-line (//) comments for brief explanations and multi-line (/* */) comments for more detailed descriptions. Comments are invaluable for explaining the purpose of code blocks, the logic behind complex operations, and any assumptions or important notes.
Task 1: Name Input Program

1. Ask the user to enter their name with the message: "Please enter your name:".
2. Capture the user's input when the Enter key is pressed and store it in a variable.
3. Display the captured name with a greeting, such as "Hello, [Name]!".
 
Task 2: Age Verification and Terms of Service Agreement Program
 
1. Prompt the user to enter their age with the message: "Please enter your age:".
2. Implement a conditional check:
If the entered age is below 18, display the message: "You must be 18 years old to use this service."
If the entered age is 18 or above, proceed to ask: "Do you agree with the terms of service? yes/no".
3. Based on the user's response to the terms of service:
If the answer is "no", display: "You must agree to the terms of service to continue."
If the answer is "yes", display: "Thank you", followed by a summary of the provided information: "Name: [their name]", "Age: [their age]", "Accepted TOS: yes".
 
Task 3: Variable Names and Types
1. Copy the below code into your development environment and run it to understand its current behavior.
2. Improve Variable Names: Replace the variable names (a, b, c, and d) with more descriptive names that reflect their purpose, like itemName, quantity, weight, and price.
3. Enhance Output Clarity: Add comments to the code, explaining what each part does.

Console.WriteLine("Enter the name of the grocery item:");
string a = Console.ReadLine(); 
Console.WriteLine("Enter the quantity:");
string b = Console.ReadLine(); 
Console.WriteLine("Enter the weight in kilograms:");
string c = Console.ReadLine(); 
Console.WriteLine("Enter the price per unit:");
string d = Console.ReadLine(); 
Console.WriteLine($"Item: {a}, Quantity: {b}, Weight: {c} kg, Price: ${d}");


Task 4: Simple Calculator Program

1. Prompt the user to enter the first number with the message: "Enter the first number:".
2. Capture the user's input and store it in a variable.
3. Prompt the user to enter the math operator symbol: +, -, /, or *.
4. Prompt the user to enter the second number with the message: "Enter the second number:".
5. Capture the user's input and store it in another variable.
6. Based on the operator entered by the user, perform the corresponding arithmetic operation on the two numbers and display the result with a message, such as "The result of 2 + 2 is 4".

Task deadline & delivery information

Create a new console app through vscode or terminal, and write your solution to each task in the Program.cs file, when you're ready to submit the task you can either upload the Program.cs file to google-classroom or you can send link to a github repository. Don't hesitate to ask if you need help.