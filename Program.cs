// See https://aka.ms/new-console-template for more information
using System;

    

	namespace switchh
	{


   class Program
   
   {
      static void Main (string[] args )
      {
          int mounth = DateTime.Now.Month;
          

          
        switch (mounth)
        {
           case 1:
           Console.WriteLine("Ocak ayındasınız.");
           break;
           case 2:
           Console.WriteLine("Şubat ayındasınız.");
           break;
           case 3:
           Console.WriteLine("Mart ayındaısnız.");
           break;
          
           default:
             Console.WriteLine("yanlış veri girdiniz.");
             break;
        }
        

        switch (mounth)
        {
            case 12:
            case 1:
            case 2:
              Console.WriteLine("Kış ayındasınız.");
              break;
              default:
              break;





        }
      }
   }
    }
