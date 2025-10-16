using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
   
    class CopyCon
    {
       
        private string month;
        private int year;

        // declaring Copy constructor
        public CopyCon(CopyCon s)
        {
            month = s.month;
            year = s.year;
        }

        // Instance constructor
        public CopyCon(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        // Get details of Geeks
        public string Details()
        {
            
                return "Month: " + month.ToString() + "\nYear: " + year.ToString();
           
        }

       
    }

}
