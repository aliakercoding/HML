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
    internal class ItemsController
    {
        // Configuring method for displaying all catalogs upon defining new item
        public static DataTable PROCEDURE_ITEMRELATEDCATALOGS()
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_ITEMRELATEDCATALOGS", CommandType.StoredProcedure);
            return dataTable;
        }

        // Configuring method for displaying all sections upon defining new item
        public static DataTable PROCEDURE_ITEMRELATEDSECTIONS()
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_ITEMRELATEDSECTIONS", CommandType.StoredProcedure);
            return dataTable;
        }

        // Configuring method for displaying all brands upon defining new item
        public static DataTable PROCEDURE_ITEMRELATEDBRANDS()
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_ITEMRELATEDBRANDS", CommandType.StoredProcedure);
            return dataTable;
        }

        // Configuring method for adding new item
        public static int PROCEDURE_ADDNEWITEM(BigInteger Barcode,string Name,decimal Rprice,decimal Vprice,byte Photo,decimal Vat,decimal Ppi,decimal Npp,decimal Uap,decimal Cap,BigInteger CatalogID,BigInteger SectionID,BigInteger BrandID)
        {
            int rowsCount =
                DataConfigurations.ExecuteNonQuery("PROCEDURE_ADDNEWITEM", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@BARCODE", SqlDbType.BigInt, Barcode),
                DataConfigurations.CreateParameter("@NAME", SqlDbType.NVarChar, Name),
                DataConfigurations.CreateParameter("@RPRICE", SqlDbType.Decimal, Rprice),
                DataConfigurations.CreateParameter("@VPRICE", SqlDbType.Decimal, Vprice),
                DataConfigurations.CreateParameter("@PHOTO", SqlDbType.Image, Photo),
                DataConfigurations.CreateParameter("@VAT", SqlDbType.Decimal, Vat),
                DataConfigurations.CreateParameter("@PPI", SqlDbType.Decimal, Ppi),
                DataConfigurations.CreateParameter("@NPP", SqlDbType.Decimal, Npp),
                DataConfigurations.CreateParameter("@UAP", SqlDbType.Decimal, Uap),
                DataConfigurations.CreateParameter("@CAP", SqlDbType.Decimal, Cap),
                DataConfigurations.CreateParameter("@CATALOGID", SqlDbType.BigInt, CatalogID),
                DataConfigurations.CreateParameter("@SECTIONID", SqlDbType.BigInt, SectionID),
                DataConfigurations.CreateParameter("@BRANDID", SqlDbType.BigInt, BrandID));

            return rowsCount;
        }
    }
}
