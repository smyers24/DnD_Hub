using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace DnD_Hub
{
    class FileIO
    {
        public string[] openListOfThings()
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

        public void OpenFileWithDefault(string fileName)
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


    }
}
