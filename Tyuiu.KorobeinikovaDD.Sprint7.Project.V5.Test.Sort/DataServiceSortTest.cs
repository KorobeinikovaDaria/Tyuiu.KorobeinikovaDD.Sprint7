using System.Data;
using Tyuiu.KorobeinikovaDD.Sprint7.Project.V5.Lib.Sort;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5.Test.Sort
{
    [TestClass]
    public class DataTableHelperTests
    {
        private DataTable dataTable;

        [TestInitialize]
        public void Setup()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("ProductCode", typeof(int));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("UnitPrice", typeof(decimal));
            dataTable.Columns.Add("Description", typeof(string));

            dataTable.Rows.Add(3, "Product C", 10, 15.5m, "Description C");
            dataTable.Rows.Add(1, "Product A", 5, 10.0m, "Description A");
            dataTable.Rows.Add(2, "Product B", 20, 20.0m, "Description B");
            dataTable.Rows.Add(0, "Product D", 8, 12.0m, "Description D");
        }

        [TestMethod]
        public void SortColumnAscending_SortsCorrectly()
        {
            var sort = new DataServiceSort();

            sort.SortColumnAscending(dataTable, "ProductCode");

            Assert.AreEqual(0, dataTable.Rows[0]["ProductCode"]);
            Assert.AreEqual(1, dataTable.Rows[1]["ProductCode"]);
            Assert.AreEqual(2, dataTable.Rows[2]["ProductCode"]);
            Assert.AreEqual(3, dataTable.Rows[3]["ProductCode"]);
        }

        [TestMethod]
        public void SortColumnDescending_SortsCorrectly()
        {
            var sort = new DataServiceSort();
            
            sort.SortColumnDescending(dataTable, "ProductCode");

            Assert.AreEqual(3, dataTable.Rows[0]["ProductCode"]);
            Assert.AreEqual(2, dataTable.Rows[1]["ProductCode"]);
            Assert.AreEqual(1, dataTable.Rows[2]["ProductCode"]);
            Assert.AreEqual(0, dataTable.Rows[3]["ProductCode"]);
        }
    }
}

