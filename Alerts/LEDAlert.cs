using System;
using System.Collections.Generic;
using System.Text;

namespace Alerts
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows = false;
        void IAlerter.Alert()
        {
                this.ledGlows = true;
        }
    }
}
