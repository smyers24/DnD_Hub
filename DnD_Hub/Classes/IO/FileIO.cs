using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;

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

        public static void WriteDataToCSV(string[][] data)
        {
            var csvData = new StringBuilder();
        }

        public static string[] LoadCSV(string fileName)
        {
            var data = File.ReadAllLines(fileName);
            return data;
        }

    }
}
