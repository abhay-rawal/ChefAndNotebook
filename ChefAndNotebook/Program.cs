using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefAndNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumberOfTestCase = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < totalNumberOfTestCase; i++)
            {
                bool result = false;
                string[] constrainsArr = Console.ReadLine().Split(' ');
                
                int pagesRequiredInitially = Convert.ToInt32(constrainsArr[0]);
                int pagesLeftInitially = Convert.ToInt32(constrainsArr[1]);
                int Budget = Convert.ToInt32(Convert.ToInt32(constrainsArr[2]));
                int NumberofNotebooks = Convert.ToInt32(Convert.ToInt32(constrainsArr[3]));
                for (int j = 0; j < NumberofNotebooks; j++)
                {
                    string[] numOfPagesAndPrice = Console.ReadLine().Split(' ');
                    int pagesInNewNoteBook =Convert.ToInt32(numOfPagesAndPrice[0]);
                    int PriceOfNewNoteBook = Convert.ToInt32(numOfPagesAndPrice[1]);

                    if (Budget >= PriceOfNewNoteBook)
                    {
                        if (pagesRequiredInitially <= pagesLeftInitially + pagesInNewNoteBook)
                        {
                            result = true;
                        }
                    }

                }
                if (result == true)
                {
                    Console.WriteLine("LuckyChef");

                }
                else Console.WriteLine("UnluckyChef");
            }
            
            
        }
    }
}
