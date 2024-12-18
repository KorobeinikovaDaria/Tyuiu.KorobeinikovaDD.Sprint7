using System.Data;

namespace Tyuiu.KorobeinikovaDD.Sprint7.Project.V5.Lib.Sort
{
    public class DataServiceSort
    {
        public DataTable SortColumnAscending(DataTable dataTable, string columnName)
        {
            if (!dataTable.Columns.Contains(columnName))
            {
                throw new ArgumentException($"Столбец '{columnName}' не существует в таблице данных");
            }

            var sortedRows = dataTable.AsEnumerable()
                .OrderBy(row => Convert.ToInt32(row.Field<object>(columnName))) // Преобразуем в int для корректной сортировки
                .ToArray();

            var sortedTable = dataTable.Clone();
            foreach (DataRow row in sortedRows)
            {
                sortedTable.ImportRow(row);
            }
            return sortedTable;
        }

        public DataTable SortColumnDescending(DataTable dataTable, string columnName)
        {
            if (!dataTable.Columns.Contains(columnName))
            {
                throw new ArgumentException($"Столбец '{columnName}' не существует в таблице данных");
            }

            var sortedRows = dataTable.AsEnumerable()
                .OrderByDescending(row => Convert.ToInt32(row.Field<object>(columnName))) // Преобразуем в int для корректной сортировки
                .ToArray();

            var sortedTable = dataTable.Clone();
            foreach (DataRow row in sortedRows)
            {
                sortedTable.ImportRow(row);
            }
            return sortedTable;
        }
    }
   }




        




