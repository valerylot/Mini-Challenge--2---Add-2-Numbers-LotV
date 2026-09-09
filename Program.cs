//Valery Lot
//09/09/2026
//Mini Challenge #2 Add 2 Numbers
//I used variables to store numbers that user input as strings, then converted it to integers and added them together
//Peer review name: Callen Thomason
//Review: Code looks great! Variables names are clear, and concatination looks good. 
// Maybe try interpolation instead of concatination next time.
//conversions are great! 
//flow chart looks good, and your code matches. 
//Code works as intended. 

Console.WriteLine("Please enter a number");
string userNum1 = Console.ReadLine();
Console.WriteLine("Please enter another number");
string userNum2 = Console.ReadLine();
int num1 = Convert.ToInt32(userNum1);
int num2 = Convert.ToInt32(userNum2);
int sum = num1 + num2;
Console.WriteLine("The sum of your numbers is: " + sum);