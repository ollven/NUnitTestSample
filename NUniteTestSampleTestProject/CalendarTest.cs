using NUnit.Framework;
using NUnitTestSample;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUniteTestSampleTestProject
{
    [TestFixture]
    public class CalendarTest
    {
        [Test]
        public void TestConvertToMonths()
        {
            var _calendar = new Calendar();
            var months = _calendar.ConvertToMonths(1);

            Assert.That(months, Is.EqualTo(12));        
        }
    }
     [TestFixture]
    public class CalendarTest1
    {
        [Test, Explicit("This test runs explisit")]
        public void TestConvertToMonths()
        {
            var _calendar = new Calendar();
            var months = _calendar.ConvertToMonths(1);

            Assert.That(months, Is.EqualTo(12));        
        }
    }
}
