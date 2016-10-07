using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionnaireRageDuCode.Models.ForumViewModels
{
    public class SujetViewModel
    {
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        // Auteur
        public DateTime DateCreation {get; set;}
        public DateTime DateDernierMessage { get; set; }
        // Dernier usager // Auteur du dernier message
        public int NbPost { get; set; }
    }
}
