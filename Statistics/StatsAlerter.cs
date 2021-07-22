using System;
using System.Collections.Generic;
using System.Text;
using Alerts;


namespace Statistics
{
    public class StatsAlerter
    {
        //public Action<double> alertHandeler = null;
        double maxThreshold;
        List<IAlerter> alertHandeler = new List<IAlerter>();
        public StatsAlerter(double maxThreshold, List<IAlerter> alerters)
        {
            this.maxThreshold = maxThreshold;
            for (int i = 0; i < alerters.Count; ++i)
                AddAlerter(alerters[i]);
        }
        public void AddAlerter(IAlerter alerter)
        {
            alertHandeler.Add(alerter);
        }
        public void CheckAndAlert(List<double> numbers)
        {
            double max = StatsComputer.CalculateStatistics(numbers).max;
            for (int i = 0; i < alertHandeler.Count; ++i)
                alertHandeler[i].Alert(maxThreshold, max);
        }
    }
}
