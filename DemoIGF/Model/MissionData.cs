using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoIGF
{
    /// <summary>
    /// classe statique utilisée pour les formulaires
    /// </summary>
    public static class MissionData
    {
        private static Microsoft.AspNetCore.Mvc.Rendering.SelectList CreerListeGrades()
        {
            List<Grade> liste = new List<Grade>
            {
                new Grade{Code="ins", Nom="Inspecteur"},
                new Grade{Code="ir",Nom="Inspecteur général"}
            };
            return new Microsoft.AspNetCore.Mvc.Rendering.SelectList(liste, "Code", "Nom");
        }

        static MissionData()
        {
            Grades = CreerListeGrades();
        }

        /// <summary>
        /// Liste des grades
        /// </summary>
        public static Microsoft.AspNetCore.Mvc.Rendering.SelectList Grades { get; private set; }
    }
}
