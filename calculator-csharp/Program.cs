Console.WriteLine("--- Calculator ---");
Console.WriteLine("Write your operation : you can use this operator => + | - | * | / | e | %");
Console.WriteLine("-> Press E to exit <-");
Console.WriteLine("Enter your first operand :");
int firstOperand = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your operator:");
string sign = Console.ReadLine();

while (sign != "+" && sign != "-" && sign != "*" && sign != "/" && sign != "e" && sign != "%")
{
    Console.WriteLine("Invalid operator entered. Please enter a valid operator:");
    sign = Console.ReadLine();
}

Console.WriteLine(" Enter your second operand :");
int secondOperand = Convert.ToInt32(Console.ReadLine());

switch (sign) {
    case "+":
        int add = firstOperand + secondOperand;
        Console.WriteLine(add);
        break;
    case "-":
        int subtract= firstOperand - secondOperand;
        Console.WriteLine(subtract);
        break;
    case "*":
        int times = firstOperand * secondOperand;
        Console.WriteLine(times);
        break;
    case "/":
        int divide = firstOperand / secondOperand;
        Console.WriteLine(divide);
        break;
    case "e":
        double power = Math.Pow(firstOperand, secondOperand);
        Console.WriteLine(power);
        break;
    case "%":
        int modulo = firstOperand % secondOperand;
        Console.WriteLine(modulo);
        break;
}