// Console.WriteLine("Hello, World!");
// Console.WriteLine($"this is my first C# line");

public class MyClass
{
    public static void Main(string[] args)
    {
      
     Console.WriteLine("Enter a temperature and its unit");
         string amount =  Console.ReadLine();
         // check the type of temperature unit
        if (amount.IndexOf("f")!= -1)
         {
            string temperatureAmount = amount.Substring(0,amount.IndexOf("f"));
            Console.WriteLine("temperature: " + TempConvert(int.Parse(temperatureAmount),"f"));
         }
         else {
               if (amount.IndexOf("c")!= -1)
         {
            string temperatureAmount = amount.Substring(0,amount.IndexOf("c"));
            Console.WriteLine("temperature: " + TempConvert(int.Parse(temperatureAmount),"c"));
         }
         }

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
                else // want to convert to F = (amount* 1.8) + 32
                if (measurementUnit == "c")
                {
                   temperature = ((amount* 1.8) + 32);
                   result = temperature + " f";
                }
   return result;
    }
    

    
}