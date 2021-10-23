using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LINQProduct
{
    class ProductDataTable
    {
        public void AddToDatatable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Rating");
            table.Columns.Add("Review");
            table.Columns.Add("isLike");

            table.Rows.Add(1, 1, 2, "good", true);
            table.Rows.Add(2, 1, 4, "good", true);
            table.Rows.Add(3, 2, 5, "good", true);
            table.Rows.Add(2, 2, 6, "good", true);
            table.Rows.Add(5, 3, 2, "nice", false);
            table.Rows.Add(6, 4, 1, "Bad", false);
            table.Rows.Add(7, 3, 1.5, "nice", false);
            table.Rows.Add(8, 3, 1.5, "nice", false);
            table.Rows.Add(9, 3, 3.5, "nice", false);
            table.Rows.Add(11, 10, 9, "nice", true);
            table.Rows.Add(10, 10, 4, "nice", true);
            table.Rows.Add(2, 10, 4, "nice", true);
            table.Rows.Add(13, 10, 4, "nice", true);
            table.Rows.Add(4, 10, 4, "nice", true);
            table.Rows.Add(15, 10, 4, "nice", true);
            table.Rows.Add(16, 10, 4, "nice", true);
            table.Rows.Add(6, 3, 1, "Bad", false);

            //DisplayProducts(table);
        }
    }
}
