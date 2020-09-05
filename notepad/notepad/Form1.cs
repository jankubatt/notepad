using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            
            savefile.FileName = ".txt";
            savefile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(textBox1.Text);               
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadfile = new OpenFileDialog();

            loadfile.FileName = ".txt";
            loadfile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (loadfile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(loadfile.FileName))
                {
                    textBox1.Text = sr.ReadToEnd();
                    
                }
                    
            }
        }
    }
}
