// Console.WriteLine("Hello, World!");
// Console.WriteLine($"this is my first C# line");

public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("temperature: " + TempConvert(25,"f"));
        //  Console.WriteLine("Enter a temperature and its unit");
        //  string amount =  Console.ReadLine();
    
//         if (amount.IndexOf("f")!= -1){
//           int tempAmount = (int)(amount.substring(amount.IndexOf("f")));
//           string tempType = amount.substring((amount.IndexOf("f")) to (amount.Length));
//           Console.WriteLine("temperature: " + TempConvert(tempAmount,tempType));

//   }

      //
    

    }

    public static string TempConvert (int amount, string measurementUnit)
    {
        double temperature; 
        string result ="";
                if (measurementUnit == "f")
                { // want to convert to "c" temperature = (amount - 32)*(0.5556)
                   temperature = ((amount-32) * (0.5556));
                    result = temperature + " c";
                }
                else   // want to convert to F = (amount* 1.8) + 32
                if (measurementUnit == "c")
                {
                   temperature = ((amount* 1.8) + 32);
                   result = temperature + " f";
                }
   return result;
    }
    

    
}