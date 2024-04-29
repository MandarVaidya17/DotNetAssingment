using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingments
{
    public class Movie
    {
        private int mid;
        private string mName;
        private double tCost;
        private string pName;

        public Movie()
        {

        }
        public Movie(int Mid, string MName, double TCost, string PName)
        {
           this.Mid = Mid;
            this.MName = MName;
            this.TCost = TCost;
            this.PName = PName;
            
        }


        public int Mid
        {
            get { return mid; }
            set { mid = value; }
                    
        }
        public string MName
        {
            get { return mName; }
            set { mName = value; }
        }

        public double TCost
        {
            get { return tCost; } 
            set {  tCost = value; } }

        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }

        public override string ToString()
        {
            return $" MovieID:{mid}, Movie Name:{mName}, Ticket Cost:{tCost}, Movie Producer:{pName}";
        }
    }
}
