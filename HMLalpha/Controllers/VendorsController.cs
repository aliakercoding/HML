using HMLalpha.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMLalpha.Controllers
{
    internal class VendorsController
    {
        // Configuring method for adding a new vendor
        public static int PROCEDURE_ADDNEWVENDOR(string VName, string VContact, string VAddress, decimal VCredit)
        {
            int rowsCount = DataConfigurations.ExecuteNonQuery("PROCEDURE_ADDNEWVENDOR", CommandType.StoredProcedure,
                 DataConfigurations.CreateParameter("@VNAME", SqlDbType.NVarChar, VName),
                 DataConfigurations.CreateParameter("@VCONTACT", SqlDbType.NVarChar, VContact),
                 DataConfigurations.CreateParameter("@VADDRESS", SqlDbType.NVarChar, VAddress),
                 DataConfigurations.CreateParameter("@VCREDIT", SqlDbType.Decimal, VCredit));
            return rowsCount;
        }

        // Configuring method for displaying all vendors
        public static DataTable PROCEDURE_DISPLAYALLVENDORS()
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_DISPLAYALLVENDORS", CommandType.StoredProcedure);
            return dataTable;
        }

        // Configuring method for searching vendors
        public static DataTable PROCEDURE_SEARCHVENDORS(string Search)
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_SEARCHVENDORS", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@SEARCHPARAMETER", SqlDbType.NVarChar, Search));
            return dataTable;
        }

        // Configuring method for selecting vendor data based on ID 
        public static DataTable PROCEDURE_SELECTVENDOR(int ID)
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_SELECTVENDOR", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return dataTable;
        }

        // Configuring method for updating vendor
        public static int PROCEDURE_UPDATEVENDOR(int ID, string VName, string VContact, string VAddress)
        {
            int rowsCount = DataConfigurations.ExecuteNonQuery("PROCEDURE_UPDATEVENDOR", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID),
                DataConfigurations.CreateParameter("@VNAME", SqlDbType.NVarChar, VName),
                DataConfigurations.CreateParameter("@VCONTACT", SqlDbType.NVarChar, VContact),
                DataConfigurations.CreateParameter("@VADDRESS", SqlDbType.NVarChar, VAddress));

            return rowsCount;
        }

        // Configuring method for deleting vendor
        public static int PROCEDURE_DELETEVENDOR(int ID)
        {
            int rowsCount = DataConfigurations.ExecuteNonQuery("PROCEDURE_DELETEVENDOR", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return rowsCount;
        }
    }
}
