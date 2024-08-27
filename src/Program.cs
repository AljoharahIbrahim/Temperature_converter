// Console.WriteLine("Hello, World!");
// Console.WriteLine($"this is my first C# line");

public class MyClass
{
    public static void Main(string[] args)
    {
 
while (true)
{
         Console.WriteLine("Enter a temperature and its unit, or type 'Quit' to exit:");
          string amount =  Console.ReadLine(); // "45 F"
          if (amount == "Quit" || amount == "quit" )
          break;
          string[] temp= amount.Split(' '); // ["45", "F"]
 
        // handling 
        // 1. check the length of the input 
        if (temp.Length != 2)
        {
         Console.WriteLine(" invalid length ");
        }
        // 2. check the temp unit 
        if (temp[1] != "f" || temp[1] != "c" )
        {
         Console.WriteLine(" invalid temperature unit ");

        }
        //3. check the temp amount 
         if (!int.TryParse(temp[0], out int num))
        {
         Console.WriteLine(" invalid temperature amount ");

        }

        try {
       //  if (calculate)
        Console.WriteLine("temperature: " + TempConvert(int.Parse(temp[0]),temp[1]));
        }
         catch (System.Exception ex)
         {
         Console.WriteLine("Exception ex");
       // TODO
         }
       

    
}
 
//-----------------------------------------//
    }

    public static string TempConvert (int amount, string measurementUnit)
    {
        double temperature; 
        string result ="";
                if (measurementUnit == "f")
                { // want to convert to "c" temperature = (amount - 32)*(0.5556)
                   temperature = ((amount-32) * (0.5556));
                   return  result = temperature + " c";
                }
                else // want to convert to F = (amount* 1.8) + 32
                if (measurementUnit == "c")
                {
                   temperature = ((amount* 1.8) + 32);
                  return result = temperature + " f";
                }
   return result;
    }
    

    
}