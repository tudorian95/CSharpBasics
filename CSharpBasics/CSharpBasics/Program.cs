
Console.WriteLine("Hello there");
/* studied:
 - breakpoints
 - variables (int/double a.k.a float/char/bool/string)
*/
Console.WriteLine("You'll now be prompted to input a numeric value");
int box = int.Parse(Console.ReadLine());
Console.WriteLine("Your value is:{0}", box);

//to do: GIT used to it + operations on ints
Console.WriteLine("Some basic integer operations with your provided value: \n");
Console.WriteLine("Addition\n What value should we add to your initial choice?");
Console.WriteLine(box + int.Parse(Console.ReadLine()));
Console.WriteLine("\nSubtraction\n What value should we subtract from your initial choice?");
Console.WriteLine(box - int.Parse(Console.ReadLine()));
Console.WriteLine("\nMultiplication\n By what value should we multiply your initial choice?");
Console.WriteLine(box * int.Parse(Console.ReadLine()));
Console.WriteLine("\nDivision\n By what value should we divide your initial choice?");
Console.WriteLine(box / int.Parse(Console.ReadLine()));
Console.WriteLine("\nModulo\n For which value should we check the integer remainder after dividing your initial choice?");
Console.WriteLine(box % int.Parse(Console.ReadLine()));