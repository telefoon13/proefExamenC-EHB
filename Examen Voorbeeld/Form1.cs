using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Examen_Voorbeeld
{
    public partial class Form1 : Form
    {
        private string selectedPath;
        private DB<Student> students;
        private int importFileCount;

        public Form1()
        {
            InitializeComponent();
            students = new DB<Student>();
            folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += backgroundWorker_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnCancel.Enabled = false;
            btnImport.Enabled = true;
            progressBar1.Value = 0;
            btnValidate.Enabled = true;
            tbResult.Text = string.Format("Import Complete {0} \r\n> {1} files imported \r\n> {2} students in the database.", DateTime.Now, importFileCount, students.Count());
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            var filePaths = Directory.EnumerateFiles(selectedPath);
            progressBar1.Maximum = filePaths.Count(); ;

            foreach (var filePath in filePaths)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    var xdoc = XDocument.Parse(File.OpenText(filePath).ReadToEnd());
                    var student = xdoc.Descendants("Student")
                        .Select(x => new Student
                        {
                            ID = int.Parse(x.Element("Id").Value),
                            Voornaam = x.Element("FirstName").Value,
                            Achternaam = x.Element("LastName").Value,
                            GeboorteDatum = DateTime.Parse(x.Element("Dob").Value)
                        }).FirstOrDefault();

                    if (student != null)
                    {
                        students.Upsert(student);
                    }
                    importFileCount++;
                    worker.ReportProgress(importFileCount);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnImport.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var res = folderBrowserDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                lbPath.Text = folderBrowserDialog1.SelectedPath;
                selectedPath = folderBrowserDialog1.SelectedPath;
                btnImport.Enabled = true;
            }
        }

        private async void btnValidate_Click(object sender, EventArgs e)
        {
            var taskAantalOngeldige = Task.Run<int>(() => students.Where(x => x.Validate() == false).Count());
            var taskStudentenOuderDan100 = Task.Run<List<Student>>(() => students.Where(x => (new DateTime(DateTime.Now.Subtract(x.GeboorteDatum).Ticks).Year - 1) > 100).ToList());
            var taskstudentenJongerDan15 = Task.Run<List<Student>>(() => students.Where(x => (new DateTime(DateTime.Now.Subtract(x.GeboorteDatum).Ticks).Year - 1) < 15).ToList());
            await Task.WhenAll(taskAantalOngeldige, taskStudentenOuderDan100, taskstudentenJongerDan15);

            string validationResult = "";
            validationResult += "Aantal ongeldige items : " + taskAantalOngeldige.Result;
            if (taskStudentenOuderDan100.Result.Count > 0)
            {
                validationResult += "\r\nOuder dan 100 : \r\n" + taskStudentenOuderDan100.Result.Print();
            }
            if (taskstudentenJongerDan15.Result.Count() > 0)
            {
                validationResult += "\r\nJonger dan 15 : \r\n" + taskstudentenJongerDan15.Result.Print();
            }
            tbValidationResults.Text = validationResult;
        }
    }
}
