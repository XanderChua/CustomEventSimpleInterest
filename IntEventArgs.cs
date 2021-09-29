using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEventSimpleInterest
{
    class IntEventArgs : EventArgs
    {
        public IntEventArgs(int principal, int interest, int timeMonths, int cal)
        {
            this.principal = principal;
            this.interest = interest;
            this.timeMonths = timeMonths;
            this.cal = cal;
        }

        public int principal { get; set; }
        public int interest { get; set; }
        public int timeMonths { get; set; }
        public int cal { get; set; }
    }
}
