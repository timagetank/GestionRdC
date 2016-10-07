using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestionnaireRageDuCode.Models.MembresViewModels
{
    public class Membres
    {
        public enum ROLE
        {
            Membre,
            Modérateur,
            Administrateur,
            Fondateur
        }

        public int ID { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Role { get; set; }
    }
}
