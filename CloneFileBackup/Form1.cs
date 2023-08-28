using CloneFileBackup.Models;
using CsvHelper;
using System.Text;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace CloneFileBackup
{
    public partial class Form1 : Form
    {
        private bool _disposed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_selectOrig_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            textBox_pathOrig.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_selectDest_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            textBox_pathDest.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            //Update JSON File with new Backup 
            List<Backup> backups = new List<Backup>();

            if (File.Exists("conf.json"))
            {
                using (StreamReader sr = new StreamReader("conf.json"))
                {
                    string json = sr.ReadToEnd();
                    backups = JsonConvert.DeserializeObject<List<Backup>>(json);
                }
            }

            using (StreamWriter sw = new StreamWriter("conf.json"))
            {
                Backup backup = new Backup
                {
                    NameBackup = textBox1.Text,
                    PathOrigin = textBox_pathOrig.Text,
                    PathDestination = textBox_pathDest.Text
                };

                backups.Add(backup);

                string json = JsonConvert.SerializeObject(backups);
                sw.WriteLine(json);
            }

            //Update Data Grid
            dataGridView1.DataSource = backups;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get Backup
            List<Backup> backups = new List<Backup>();

            if (File.Exists("conf.json"))
            {
                using (StreamReader sr = new StreamReader("conf.json"))
                {
                    string json = sr.ReadToEnd();
                    backups = JsonConvert.DeserializeObject<List<Backup>>(json);
                }
            }

            //Update Data Grid
            dataGridView1.DataSource = backups;
            _disposed = true;
        }

        private void button_execute_Click(object sender, EventArgs e)
        {
            //File.Copy(textBox_pathOrig.Text, textBox_pathDest.Text, true);
            Copy(textBox_pathOrig.Text, textBox_pathDest.Text);
        }

        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            CopyAll(diSource, diTarget);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            // Copy each file into the new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (_disposed)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox_pathOrig.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_pathDest.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}