using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HMLalpha.Models;
namespace HMLalpha.Controllers
{
    internal class CatalogsController
    {
        // Configuring method for adding a new catalog. 
        public static int PROCEDURE_ADDNEWCATALOG(string CatalogName)
        {
            int rowsCount = 
            DataConfigurations.ExecuteNonQuery("PROCEDURE_ADDNEWCATALOG", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@CATALOG_NAME", SqlDbType.NVarChar, CatalogName));
            return rowsCount;
        }
    }
}
