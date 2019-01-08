using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FreadUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Invoke a file dialog and Choose a file to view

        private void chooseButton_Click(object sender, EventArgs e)
        {
                OpenFileDialog f = new OpenFileDialog();

            if (f.ShowDialog() == DialogResult.OK)

            //Make sure the listBox is empty
            //Populate the listBox with the chosen text file

            {
                listBox1.Items.Clear();
                List<string> lines = new List<string>();


                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                        listBox1.Items.Add(line);
                }
            }
            //Should the user choose cancel on the file dialog

            else if (f.ShowDialog() == DialogResult.Cancel)

            {
                listBox1.Items.Clear();
                MessageBox.Show(string.Format("No file chosen"));
            }

        }
        // If user clicks exit close the application.

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
