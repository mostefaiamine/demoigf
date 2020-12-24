using System;
using System.Collections.Generic;
using System.Text;

namespace DemoIGF
{
    /// <summary>
    /// Cette classe permet le calcul de taux par grade 
    /// </summary>
    public class GradeTaux
    {
        /// <summary>
        /// Cette méthode permet le calcul de taux de frais de mission
        /// </summary>
        /// <param name="grade">Le grade de l'inspecteur</param>
        /// <param name="jours">Le nombre de jours</param>
        /// <returns>Le taux utilisé pour les calculs</returns>
        public decimal CalculTaux(string grade, int jours)
        {
            if(jours > 10)
            {
                return 0.8m;
            }
            else
            {
                return 1;
            }
        }
    }
}
