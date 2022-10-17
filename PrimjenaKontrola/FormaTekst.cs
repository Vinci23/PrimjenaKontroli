using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaKontrola
{
    public partial class FormaTekst : Form
    {
        public static string passingText;

        public FormaTekst()
        {
            InitializeComponent();
            
    }
        

        private void btnOK_Click(object sender, EventArgs e)
        {


            passingText = textBox1.Text;
            Form1 form = new Form1();
            form.Show();
        }
    }
}
