using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    partial class Form_Take_Book : Form
    {
        public Form_Book_Section_Show MainForm { get; set; }



        public Form_Take_Book()
        {
            InitializeComponent();
        }


        private void button_Take_Click(object sender, EventArgs e)
        {
            bool ok = true;
            int num;

            try
            {
                num = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                ok = false;
                MessageBox.Show(
                    "Некорректне число!",
                    "Увага!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }

            if (ok == true)
            {
                if (MainForm.MainForm.Get_MainLibraryContainer().Find_Reader(Convert.ToInt32(textBox1.Text)))
                    this.DialogResult = DialogResult.OK;

                else
                {
                    ok = false;
                    MessageBox.Show(
                        "Даного читача не існує!",
                        "Увага!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                }
            }
                
        }
    }
}
