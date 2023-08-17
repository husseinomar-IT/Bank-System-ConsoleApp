using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinisLayer
{
 public    class clsInputValidate

    {

       public  static bool IsNumberBetween(int Num, int From, int To)
        {
            if (Num >= From && Num <= To)
                return true;
            else
                return false;
        }




    


       public static bool IsNumberBetween(short Num, short From, short To)
        {
            if (Num >= From && Num <= To)
                return true;
            else
                return false;
        }




       public static bool IsNumberBetween(float Num, float From, float To)
        {
            if (Num >= From && Num <= To)
                return true;
            else
                return false;
        }


        public static bool IsNumberBetween(double Num, double From, double To)
        {

            if (Num >= From && Num <= To)
                return true;
            else
                return false;
        }



     public    static int ReadIntNumber(string MassageError="Invalid Number, Enter again:\n")
	{
		
			string NumInput;
            int NumOut;
           NumInput=Console.ReadLine();
     
			while (!int.TryParse (NumInput, out NumOut))
			{
                Console.WriteLine (MassageError);
                NumInput = Console.ReadLine();
				
			}
            return NumOut;
		}





     public static double  ReaddblNumber(string MassageError = "Invalid Number, Enter again:\n")
     {

         string NumInput;
         double NumOut;
         NumInput = Console.ReadLine();

         while (!double . TryParse(NumInput, out NumOut))
         {
             Console.WriteLine(MassageError);
             NumInput = Console.ReadLine();

         }
         return NumOut;
     }



     public static short ReadShortNumber(string MassageError = "Invalid Number, Enter again:\n")
        {

            string NumInput;
            short NumOut;
            NumInput = Console.ReadLine();

            while (!short.TryParse(NumInput, out NumOut))
            {
                Console.WriteLine(MassageError);
                NumInput = Console.ReadLine();

            }
            return NumOut;
        }





   



     public static short ReadshortNumberBetween(short from, short to, string MassageError = "Number is not within range, Enter again:\n")
        {
            short Num = ReadShortNumber();
            while (!IsNumberBetween(Num, from, to))
            {
                Console.Write(MassageError);
                Num = ReadShortNumber();
            }
            return Num;

        }

    }
}
