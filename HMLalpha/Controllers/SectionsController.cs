using HMLalpha.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMLalpha.Controllers
{
    internal class SectionsController
    {
        // Configuring method for adding a new section. 
        public static int PROCEDURE_ADDNEWSECTION(string SectionName)
        {
            int rowsCount =
            DataConfigurations.ExecuteNonQuery("PROCEDURE_ADDNEWSECTION", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@SECTION_NAME", SqlDbType.NVarChar, SectionName));
            return rowsCount;
        }
    }
}
