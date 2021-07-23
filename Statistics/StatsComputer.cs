using System;
using System.Collections.Generic;
using Alerts;

namespace Statistics
{   
    public class StatsComputer
    {
        public class StatsDataModel
        {
            public double average;
            public double max;
            public double min;
            public StatsDataModel(double _average = Double.NaN, double _max = Double.NaN, double _min = Double.NaN)
            {
                this.average = _average;
                this.max = _max;
                this.min = _min;
            }
        }
        StatsDataModel stats = new StatsDataModel();
        
        public StatsDataModel CalculateStatistics(List<double> numbers)
        {
            if (numbers.Count == 0)
                return new StatsDataModel();
            this.stats.max = numbers[0];
            this.stats.min = numbers[0];
            this.stats.average = 0;
            foreach(float number in numbers)
            {
                if (Double.NaN.Equals(number))
                    return new StatsDataModel();
                if (number > this.stats.max)
                    this.stats.max = number;
                if (number < this.stats.min)
                    this.stats.min = number;
                this.stats.average += number;
            }
            this.stats.average /= numbers.Count;
            return stats;
        }
    }   
}

