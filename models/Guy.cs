using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER17CASH.models
{
    public class Guy
    {
        public int Cash { get; set; }
        public string Name { get; set; }
        public void GiveCash(int CashGiveIt)
        {
            this.Cash=Cash-CashGiveIt;
        }
        public void RecieveCash(int CashRecieveIt)
        {
            this.Cash = Cash + CashRecieveIt;
        }
    }
}
