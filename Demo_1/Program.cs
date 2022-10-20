using System;

namespace Demo_1
{
    class Program
    {
        static double DivideNumber(double num1, double num2)  
        {  
            if (num1 < num2)  
            num1 += 20;  
            return num1 / num2;  
        }  
        
        static void Main(string[] args)
        {
            try  
            {  
                string mystring = default;  
                mystring.Insert(0, "hello");  
  
                int i = 20; int j = 0;  
                double result = DivideNumber(i, j);  
  
                object obj = default;  
                int i2 = (int)obj; // Suspect of casting error  
  
            }  
            catch (StackOverflowException ex)  
            {  
                Console.WriteLine("Overflow. {0}", ex.Message);  
            }  
            catch (DivideByZeroException ex)  
            {  
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);  
            }  
            catch (InvalidCastException ex)  
            {  
                Console.WriteLine("Invalid casting. {0}", ex.Message);  
            }  
            catch (Exception ex)  
            {  
                Console.WriteLine("General exception. {0}", ex.Message);  
            }  
        }
    }
}
