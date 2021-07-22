using System;
using System.Collections.Generic;
using Alerts;

namespace Statistics
{
    //Was thinking of using function pareadigm but decide to use OOP.

    //public interface ICalculateStatistics
    //{
    //    Stats CalculateStatistics(List<double> numbers);
    //}
    
    public class StatsComputer
    {
        static public StatsDataModel CalculateStatistics(List<double> numbers) {
            //Implement statistics here
            double average;
            double max;
            double min;
            if (numbers.Count == 0)
                return new StatsDataModel();
            max = numbers[0];
            min = numbers[0];
            average = 0;
            foreach(float number in numbers)
            {
                if (number > max)
                    max = number;
                if (number < min)
                    min = number;
                average += number;
            }
            average /= numbers.Count;
            return ( new StatsDataModel(average, max, min) );
        }
    }
    
    //static Func<double, bool> CheckArgumentGreateThanDouble(double b)
    //{
    //    bool Check(double a)
    //    {
    //        return a>b;
    //    }
    //    return Check;
    //}
    
}

