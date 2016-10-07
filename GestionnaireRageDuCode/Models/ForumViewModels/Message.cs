using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionnaireRageDuCode.Models.ForumViewModels
{
    public class Message
    {
        public int ID { get; set; }
        public string Corps { get; set; }
        public DateTime DateCreation { get; set; }
        // Auteur
    }
}
