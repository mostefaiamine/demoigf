using System;
using Xunit;

namespace DemoIGF.Tests
{
    public class MissionServiceTest
    {
        [Fact]
        public void CalcTest()
        {
            IMissionService ser = new MissionService();
            var val = ser.Calculer("ins", 5);
            Assert.Equal(15000m, val);
            val = ser.Calculer("ir", 7);
            Assert.Equal(35000, val);
            Assert.Throws<ApplicationException>(() => val = ser.Calculer("grd", 12));
        }
    }
}
