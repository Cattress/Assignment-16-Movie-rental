using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_Movie_rental
{
    class Movie
    {

        private string name;
        private int duration;
        private bool availability;

        public Movie(string name, int duration)
        {
            this.name = name;

        }

        public int GetLength()
        {
            return duration;
        }

        public string GetName()
        {
            return name;
        }

        public bool GetAvailable()
        {
            return availability;
        }

        public bool IsAvailable()
        {
            if (availability == true)
            {
                return availability;
            }
            else
            {
                return availability;
            }

        }

       public void BorrowMoney()
       {
            if (availability == false)
            {
            }

       }

    }
}
