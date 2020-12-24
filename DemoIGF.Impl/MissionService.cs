using System;

namespace DemoIGF
{
    public class MissionService : IMissionService
    {
        // Commentaire PC 1
        public decimal Calculer(string grade, int jours)
        {
            decimal taux = 0;
            var grd = new GradeTaux();
            switch (grade)
            {
                case "ins":
                    taux = 3000;
                    break;
                case "ir":
                    taux = 5000;
                    break;
            }
            return taux * jours * grd.CalculTaux(grade, jours);
        }
    }
}
