using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class MovieImplement
    {
        Movie[] moviesArr = new Movie[3];
        int count = 0;


        public void InsertMovieDetails()
        {
            Console.WriteLine("Enter Movie Details");
            for (int i = 0; i < moviesArr.Length; i++)
            {
                Console.WriteLine("Enter Movie Id");
                int Mid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Movie Name:");
                string MName = Console.ReadLine();
                Console.WriteLine("Enter Tiket Cost");
                double TCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Movie Producer");
                string PName = Console.ReadLine();
                moviesArr[count++] = new Movie(Mid, MName, TCost, PName);
            }

        }
        public void UpdateMovieDetails()
        {
            Console.WriteLine("Update Movie ");
            Console.WriteLine("Enter Movie Id ");
            int mid = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < moviesArr.Length; i++)
            {
                if (moviesArr[i].Mid == mid)
                {
                    Console.WriteLine("Enter Tiket Cost");
                    double TCost = Convert.ToDouble(Console.ReadLine());
                    moviesArr[i].TCost = TCost;
                }
            }

        }

        public void DeleteMovieDetails()
        {
            Console.WriteLine("Enter id to delete");
            Console.WriteLine("Enter Movie Id ");
            int mid = Convert.ToInt32(Console.ReadLine());
            for (int i = mid-1; i < moviesArr.Length-1; i++)
            {
                moviesArr[i] = moviesArr[i + 1];
            }
            Array.Resize(ref moviesArr, moviesArr.Length-1);

        }

        public void SearchByName()
        {
            Console.WriteLine("Enter Movie Name");
            string mname=Console.ReadLine();
            mname = mname.ToLower();
            foreach(Movie movie in moviesArr) 
            {
                if (movie.MName.ToLower() == mname.ToLower())
                {
                    Console.WriteLine(movie.ToString());
                    break;
                }
                
            }
        }

        public void DisplayMovieDisplay()
        {
            foreach (Movie movie in moviesArr)
            {
                Console.WriteLine(movie.ToString());
            }
        }

        public void FindMovie()
        {
            Console.WriteLine("Enter Movie ID To find");
            int mid= Convert.ToInt32(Console.ReadLine());
            foreach(Movie movie in moviesArr)
            {
                if(movie.Mid == mid)
                {
                    Console.WriteLine(movie.ToString());
                }
                else
                {
                    Console.WriteLine("NOt Found");
                }
            }
        }
    }
}
