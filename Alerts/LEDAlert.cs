using System;
using System.Collections.Generic;
using System.Text;

namespace Alerts
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows = false;
        public void Alert()
        {
                this.ledGlows = true;
        }
    }
}
