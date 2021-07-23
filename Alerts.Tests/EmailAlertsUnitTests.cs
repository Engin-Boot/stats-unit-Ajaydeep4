using System;
using Xunit;
using Alerts;

namespace Alerts.Tests
{
    public class EmailAlertsUnitTests
    {
        [Fact]
        public void Alerts_EmailAlertCalled_ChnagesEmailAlertObjectStates()
        {
            EmailAlert emailAlert = new EmailAlert();

            emailAlert.Alert();

            Assert.True(emailAlert.emailSent);
        }
    }
}
