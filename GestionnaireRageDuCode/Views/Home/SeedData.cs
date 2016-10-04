using GestionnaireRageDuCode.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionnaireRageDuCode.Views.Home
{
    public class SeedData
    {
        static public ApplicationDbContext context { get; set; }

        static public void ListerMembres()
        {
            context.SaveChanges();
        }
    }
}
