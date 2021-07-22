using System;
using System.Collections.Generic;
using System.Text;

namespace Alerts
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent = false;
        void IAlerter.Alert(double maxThreshold, double max)
        {
            if (max > maxThreshold)
            {
                this.emailSent = true;
            }
        }
    }
}
