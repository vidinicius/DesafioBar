using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBar
{
    class Bill
    {
        public char Gender;
        public int Beer;
        public int Barbecue;
        public int SoftDrink;

        public double Cover()
        {
            if (Feeding() > 30)
            {
                return 0;
            }
            else
            {
                return 4;
            }
        }

        public double Feeding()
        {
            return Beer * 5 + SoftDrink * 3 + Barbecue * 7;

        }
        public double Ticket()
        {
            if(Gender == 'F' || Gender == 'f')
            {
                return 8;
            }
            else
            {
                return 10;
            }

        }

        public double Total()
        {
            return Cover() + Feeding() + Ticket();
        }



    }
}
