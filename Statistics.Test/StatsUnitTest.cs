using System;
using Xunit;
using Statistics;
using Alerts;

using System.Collections.Generic;
namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> {1.5, 8.9, 3.2, 4.5});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 4.525) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 8.9) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 1.5) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> { });
            Assert.True(Double.NaN.Equals(computedStats.average));
            Assert.True(Double.NaN.Equals(computedStats.max));
            Assert.True(Double.NaN.Equals(computedStats.min));
        }
        [Fact]
        public void ReportsNaNIfInputContainsNaN()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<double> { 1.5, 8.9, double.NaN, 4.5 });
            Assert.True(Double.NaN.Equals(computedStats.average));
            Assert.True(Double.NaN.Equals(computedStats.max));
            Assert.True(Double.NaN.Equals(computedStats.min));
        }
        [Fact]
        public void RaisesAlertsIfMaxIsMoreThanThreshold()
        {
            var emailAlert = new EmailAlert();
            var ledAlert = new LEDAlert();
            IAlerter[] alerters = { emailAlert, ledAlert };
            List<IAlerter> alertersList = new List<IAlerter>(alerters);
            const double maxThreshold = 10.2;
            var statsAlerter = new StatsAlerter(maxThreshold, alertersList);
            statsAlerter.CheckAndAlert(new List<double> { 0.2, 11.9, 4.3, 8.5 });

            Assert.True(emailAlert.emailSent);
            Assert.True(ledAlert.ledGlows);
        }
    }
}
