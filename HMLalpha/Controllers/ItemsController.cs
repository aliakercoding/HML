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
        public static int PROCEDURE_ADDNEWITEM(long Barcode, string Name, decimal Rprice, decimal Vprice, byte[] Photo, decimal Vat, decimal Ppi, decimal Npp, decimal Uap, decimal Cap, long CatalogID, long SectionID, long BrandID)
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

        // Configuring method for displaying all items
        public static DataTable PROCEDURE_DISPLAYALLITEMS()
        {
            DataTable dataTable =
                DataConfigurations.ExecuteTable("PROCEDURE_DISPLAYALLITEMS", CommandType.StoredProcedure);
            return dataTable;

        }

        // Configuring method for searching items
        public static DataTable PROCEDURE_SEARCHITEMS(string Search)
        {
            DataTable dataTable =
                DataConfigurations.ExecuteTable("PROCEDURE_SEARCHITEMS", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@SEARCHPARAMETER", SqlDbType.NVarChar, Search));
            return dataTable;
        }

        // Configuring method for displaying item related photo
        public static byte[] PROCEDURE_DISPLAYITEMPHOTO(long ID)
        {
            byte[] array =
               (byte[])DataConfigurations.ExecuteScalar("PROCEDURE_DISPLAYITEMPHOTO", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return array;
        }

        // Configuring method for displaying item related expiry date
        public static DataTable PROCEDURE_DISPLAYITEMEXPIRY(long ID)
        {
            DataTable dataTable = DataConfigurations.ExecuteTable("PROCEDURE_DISPLAYITEMEXPIRY", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return dataTable;
        }

        // Configuring method for deleting items
        public static int PROCEDURE_DELETEITEM(long ID)
        {
            int rowsCount =
                DataConfigurations.ExecuteNonQuery("PROCEDURE_DELETEITEM", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return rowsCount;
        }

        // Configuring method for selecting item data based on ID
        public static DataTable PROCEDURE_SELECTITEM(long ID)
        {
            DataTable dataTable =
                            DataConfigurations.ExecuteTable("PROCEDURE_SELECTITEM", CommandType.StoredProcedure,
                            DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID));
            return dataTable;
        }

        // Configuring method for updating item data
        public static int PROCEDURE_UPDATEITEM(long ID, long Barcode, string Name, decimal Rprice, decimal Vprice, byte[] Photo, decimal Vat, decimal Ppi, decimal Npp, decimal Uap, decimal Cap, long CatalogID, long SectionID, long BrandID)
        {
            int rowsCount =
                DataConfigurations.ExecuteNonQuery("PROCEDURE_UPDATEITEM", CommandType.StoredProcedure,
                DataConfigurations.CreateParameter("@ID", SqlDbType.BigInt, ID),
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
