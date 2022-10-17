using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PrimjenaKontrola
{
    public partial class Form1 : Form
    {
        public static string passingText;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void chbProgramAction_CheckedChanged(object sender, EventArgs e)
        {
            grbRunAProgram.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme","Obavještenje",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string selected = cmbOdabir.SelectedItem.ToString();
            if (selected == "Notepad")
                Process.Start("notepad.exe");
            else
                Process.Start("mspaint.exe");

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaTekst frm = new FormaTekst();
            DialogResult rez = frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtProgramName.Text = Form1.passingText;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
