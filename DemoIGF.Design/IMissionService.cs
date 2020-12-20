using System;
using System.Collections.Generic;
using System.Text;

namespace DemoIGF
{
    public interface IMissionService
    {
        /// <summary>
        /// Calcule le montant des frais de mission selon le grade
        /// </summary>
        /// <param name="grade">Le grade du collaborateur</param>
        /// <param name="jours">Le nombre de jours de la mission</param>
        /// <returns>Le montant de la mission</returns>
        decimal Calculer(string grade, int jours);
    }
}
