using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HMLalpha.Models;
namespace HMLalpha.Controllers
{
    internal class LoginController
    {
        // Configuring login functionality.
        public static DataTable PROCEDURE_LOGIN(string userName, string userPasscode)
        {
            DataTable dataTable =
            DataConfigurations.ExecuteTable("PROCEDURE_LOGIN", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@USERNAME", SqlDbType.NVarChar, userName),
                DataConfigurations.CreateParameter("@USERPASSCODE", SqlDbType.NVarChar, userPasscode));
            return dataTable;
        }

    }
}
