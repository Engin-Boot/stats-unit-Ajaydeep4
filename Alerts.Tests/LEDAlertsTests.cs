using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Alerts;
namespace Alerts.Tests
{
    public class LEDAlertsUnitTests
    {
        [Fact]
        public void Alerts_EmailAlertCalled_ChnagesEmailAlertObjectStates()
        {
            var ledAlert = new LEDAlert();

            ledAlert.Alert();

            Assert.True(ledAlert.ledGlows);
        }
    }
}
