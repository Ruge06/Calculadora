	
public class Program
{

    const double gravityValue = 9.8;
    static int age = 4;
    public static void Main()
    {
        /*int myNum =5;
			
		double myDobleNum = 5.99D;
			
		char myLetter = 'D';
			
		bool myBool = true;
			
		string myText = "Hello";
		Console.WriteLine("Por favor ingrese su nombre");
		string name = Console.ReadLine();
		Console.WriteLine(myText);
		
		Console.WriteLine(myNum);
		Console.WriteLine(myDobleNum);
		Console.WriteLine(myLetter);
		Console.WriteLine(myBool);
		*/

        /*age = 5;
        Console.WriteLine(age);

        age = 6;
        Console.WriteLine(age);
        */

        /*
		int x = 5;
		int y = 6;
		Console.WriteLine(x.ToString() + y.ToString());
		*/

        /*
		int x, y;
		x = y = 5;
		Console.WriteLine(x.ToString() + y.ToString());
		*/

        Console.WriteLine("Ingrese el valor 1");
        string value1 = Console.ReadLine();
        int value1Number = Int32.Parse(value1);

        Console.WriteLine("Ingrese el valor 2");
        string value2 = Console.ReadLine();
        int value2Number = Int32.Parse(value2);

        //sumando numero
        Console.WriteLine("");
        Console.WriteLine("Suma");
        Console.WriteLine(value1Number + value2Number);
        Console.WriteLine("");
        Console.WriteLine("Resta");
        Console.WriteLine(value1Number - value2Number);
        Console.WriteLine("");
        Console.WriteLine("Multiplicacion");
        Console.WriteLine(value1Number * value2Number);
        Console.WriteLine("");
        Console.WriteLine("Division");
        Console.WriteLine(value1Number / value2Number);
    }

}
