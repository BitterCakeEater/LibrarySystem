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
    public partial class Form_Add_Book : Form
    {
        public Form_Add_Book()
        {
            InitializeComponent();
        }


        private void button_Add_Click(object sender, EventArgs e)
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
                this.DialogResult = DialogResult.OK;
        }
    }
}
