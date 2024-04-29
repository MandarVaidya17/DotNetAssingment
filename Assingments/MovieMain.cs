using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class MovieMain
    {
        static void Main(string[] args)
        {
            MovieImplement obj = new MovieImplement();
            
            int choice;
            char c;
            do
            {


                Console.WriteLine("1.Add Movie 2.Update Movie ");
                Console.WriteLine("3.Delete Movie 4.Display Movie 5.Find Movie(ID)");
                Console.WriteLine("6.Search Movie(Name)");
                Console.WriteLine("Enter the choise");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        obj.InsertMovieDetails();
                        break;
                    case 2:
                        obj.UpdateMovieDetails();
                        break;
                    case 3:
                        obj.DeleteMovieDetails();
                        break;
                    case 4:
                        obj.DisplayMovieDisplay();
                        break;
                    case 5:
                        obj.FindMovie();
                        break;
                    case 6:
                        obj.SearchByName();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
                Console.WriteLine("Do you want to continue Y/N");
                     c = Convert.ToChar(Console.ReadLine());
            }while (c=='y'|| c== 'Y');
            
        }
    }
}
