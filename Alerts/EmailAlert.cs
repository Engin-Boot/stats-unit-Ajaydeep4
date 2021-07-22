using System;
using System.Collections.Generic;
using System.Text;

namespace Alerts
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent = false;
        void IAlerter.Alert()
        {
                this.emailSent = true; 
        }
    }
}
