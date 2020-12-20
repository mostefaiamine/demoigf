using System;

namespace DemoIGF
{
    public class MissionService : IMissionService
    {
        public decimal Calculer(string grade, int jours)
        {
            switch (grade)
            {
                case "ins":
                    return 3000 * jours;
                case "ir":
                    return 5000 * jours;
            }
            throw new ApplicationException("Grade invalide");
        }
    }
}
