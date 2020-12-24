using System;
using Xunit;

namespace DemoIGF.Tests
{
    public class MissionServiceTest
    {
        [Fact]
        public void CalculFraisTest()
        {
            // Préparation de test
            MissionService ser = new MissionService();
            // envoi de données
            decimal res = ser.Calculer("ins", 5);
            // Hypothèse
            Assert.Equal(15000m, res);
            // ir 5 jours
            res = ser.Calculer("ir", 5);
            Assert.Equal(25000m, res);
            // ins 20
            res = ser.Calculer("ins", 20);
            Assert.Equal(48000m, res);
            // ir 20
            res = ser.Calculer("ir", 20);
            Assert.Equal(80000m, res);
        }
    }
}
