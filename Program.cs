

class Calculator{
    static void Main(){
        Console.WriteLine("Enter a number");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator");
        #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string op = Console.ReadLine();
        
        #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Console.WriteLine("Enter another number");
        double num2 = Convert.ToDouble(Console.ReadLine());



        if (op == "+"){
            Console.WriteLine(num1 + num2);
        }else if (op == "-"){
            Console.WriteLine(num1 - num2);
        }else if (op == "*"){
            Console.WriteLine(num1 * num2);
        }else if (op == "/"){
            Console.WriteLine(num1 / num2);
        }else{
            Console.WriteLine("Invalid opereator");
        }

    }


    
   
}

