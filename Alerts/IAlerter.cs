using System;

namespace Alerts
{
    public interface IAlerter
    {
        void Alert(double maxThreshold, double max);
    }
    
}
