using HMLalpha.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HMLalpha.Controllers
{
    internal class BrandsController
    {
        // Configuring method for adding a new brand. 
        public static int PROCEDURE_ADDNEWBRAND(string BrandName)
        {
            int rowsCount =
            DataConfigurations.ExecuteNonQuery("PROCEDURE_ADDNEWBRAND", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@BRAND_NAME", SqlDbType.NVarChar, BrandName));
            return rowsCount;
        }

        // Configuring method for displaying all brands
        public static DataTable PROCEDURE_DISPLAYALLBRANDS()
        {
            DataTable dataTable =
            DataConfigurations.ExecuteTable("PROCEDURE_DISPLAYALLBRANDS", CommandType.StoredProcedure);
            return dataTable;
        }

        // Configuring method for selecting brand data based on ID
        public static DataTable PROCEDURE_SELECTBRAND(int ID)
        {
            DataTable dataTable =
                DataConfigurations.ExecuteTable("PROCEDURE_SELECTBRAND", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return dataTable;
        }

        // Configuring method for searching brands
        public static DataTable PROCEDURE_SEARCHBRANDS(string Search)
        {
            DataTable dataTable =
                DataConfigurations.ExecuteTable("PROCEDURE_SEARCHBRANDS", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@SEARCHPARAMETER", SqlDbType.NVarChar, Search));
            return dataTable;
        }

        // Configuring method for updating brand
        public static int PROCEDURE_UPDATEBRAND(int ID, string BrandName)
        {
            int rowsCount =
                DataConfigurations.ExecuteNonQuery("PROCEDURE_UPDATEBRAND", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID),
                DataConfigurations.CreateParameter("@BRAND_NAME", SqlDbType.NVarChar, BrandName));
            return rowsCount;
        }

        // Configuring method for deleting brand
        public static int PROCEDURE_DELETEBRAND(int ID)
        {
            int rowsCount =
                DataConfigurations.ExecuteNonQuery("PROCEDURE_DELETEBRAND", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return rowsCount;
        }
    }
}
