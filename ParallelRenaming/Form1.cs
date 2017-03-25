using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ookii.Dialogs;
using System.IO;

namespace ParallelRenaming
{
    public partial class Form : System.Windows.Forms.Form
    {

        private const string MB_TITLE = "Parallel Renaming";
        public Form()
        {
            

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Browse1_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog folderBrowserDialog = new VistaFolderBrowserDialog();
            if (Directory.Exists(txb_Directory1.Text))
                folderBrowserDialog.SelectedPath = txb_Directory1.Text;

            if (!VistaFolderBrowserDialog.IsVistaFolderDialogSupported)
                MessageBox.Show(this, "Because you are not using Windows Vista or later, the regular folder browser dialog will be used. Please use Windows Vista to see the new dialog.", MB_TITLE);
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                txb_Directory1.Text = (folderBrowserDialog.SelectedPath);
        }

        private void btn_Browse2_Click(object sender, EventArgs e)
        {
            VistaFolderBrowserDialog folderBrowserDialog = new VistaFolderBrowserDialog();
            if (Directory.Exists(txb_Directory2.Text))
                folderBrowserDialog.SelectedPath = txb_Directory2.Text;

            if (!VistaFolderBrowserDialog.IsVistaFolderDialogSupported)
                MessageBox.Show(this, "Because you are not using Windows Vista or later, the regular folder browser dialog will be used. Please use Windows Vista to see the new dialog.", MB_TITLE);
            if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                txb_Directory2.Text = (folderBrowserDialog.SelectedPath);
        }

        private void btn_Rename_Click(object sender, EventArgs e)
        {
            if (CheckRequirements())
            {
                bool sucess1 = false;
                bool sucess2 = false;
                try
                {
                    string file1current = txb_Directory1.Text + "\\" + txb_CurrentName.Text + getExtension();
                    string file1new = txb_Directory1.Text + "\\" + txb_NewName.Text + getExtension();

                    File.Move(file1current, file1new);
                    sucess1 = true;

                    string file2current = txb_Directory2.Text + "\\" + txb_CurrentName.Text + getExtension();
                    string file2new = txb_Directory2.Text + "\\" + txb_NewName.Text + getExtension();

                    File.Move(file2current, file2new);
                    sucess2 = true;
                }
                catch (Exception) { }

                string results = "";

                if (sucess1)
                {
                    results += "\nFile In Directory 1 Renamed";
                } else
                {
                    results += "\nERROR.... File In Directory 1 Not Renamed";
                }
                if (sucess2)
                {
                    results += "\nFile In Directory 2 Renamed";
                }
                else
                {
                    results += "\nERROR.... File In Directory 2 Not Renamed";
                }

                MessageBox.Show(results, MB_TITLE);
            }
        }

        private bool CheckRequirements()
        {
            if (!Directory.Exists(txb_Directory1.Text))
            {
                MessageBox.Show("Directory 1 Does Not Exist", MB_TITLE);
                return false;
            }

            if (!Directory.Exists(txb_Directory2.Text))
            {
                MessageBox.Show("Directory 2 Does Not Exist", MB_TITLE);
                return false;
            }

            if (String.IsNullOrEmpty(txb_CurrentName.Text))
            {
                MessageBox.Show("Enter A Current Name", MB_TITLE);
                return false;
            }

            if (String.IsNullOrEmpty(txb_Extension.Text))
            {
                MessageBox.Show("Enter an Extension", MB_TITLE);
                return false;
            }

            if (String.IsNullOrEmpty(txb_NewName.Text))
            {
                MessageBox.Show("Enter A New Name", MB_TITLE);
                return false;
            }

            if (!File.Exists(txb_Directory1.Text + "\\" + txb_CurrentName.Text + getExtension()))
            {
                MessageBox.Show("File Non Existent In Directory 1");
                return false;
            }

            if (!File.Exists(txb_Directory2.Text + "\\" + txb_CurrentName.Text + getExtension()))
            {
                MessageBox.Show("File Non Existent In Directory 2");
                return false;
            }



            return true;
        }

        private string getExtension()
        {
            string extension = String.Empty;

            if (txb_Extension.Text != String.Empty)
            {
                extension = txb_Extension.Text;
                if (extension.Contains("."))
                    extension = extension.Replace(".", "");
                return "." + extension;
            }
            return "NO EXTENSION LOADED";
        }

    }
}
