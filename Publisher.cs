using System;
using System.Collections.Generic;
using System.Text;

namespace CustomEventSimpleInterest
{
    class Publisher
    {
        public event EventHandler<IntEventArgs> modifiedEvent;
        public void CalcSimpleInterest(int principal, int interest, int timeMonths)
        {
            int cal = principal * interest * timeMonths;
            IntEventArgs arg = new IntEventArgs(principal, interest, timeMonths, cal);
            if (modifiedEvent != null)
            {
                modifiedEvent(this, arg);//raise event
            }
        }
    }
}
