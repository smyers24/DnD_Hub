using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Linq;
using System.Collections.Generic;

namespace IO
{
    static class FileIO
    {
        public static string[] openListOfThings()
        {
            string[] files = Array.Empty<string>();
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                files = File.ReadAllLines(fileDialog.FileName);
            }
            foreach (string file in files)
            {
                OpenFileWithDefault(file);
            }
            return files;
        }

        public static void OpenFileWithDefault(string fileName)
        {
            Process fileopener = new Process();
            try
            {
                fileopener.StartInfo.FileName = fileName;
                fileopener.Start();
                fileopener.Close();
            }
            catch
            {
                MessageBox.Show("Invalid file selection: " + fileName);
            }
        }
        public static void WriteDataToCSV(DataTable dt, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            var systemPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            var complete = Path.Combine(systemPath, fileName);
            File.WriteAllText(complete, sb.ToString());
        }
        public static string[] LoadCSV(string fileName)
        {
            var data = File.ReadAllLines(fileName);
            return data;
        }

    }
}
