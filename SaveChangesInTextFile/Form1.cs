using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveChangesInTextFile
{
    public partial class MyNoteBook : Form
    {
        public MyNoteBook()
        {
            InitializeComponent();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void MenuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "TXT files|*.txt";
            op.InitialDirectory = @"\";//@"C:\";

            if (op.ShowDialog() == DialogResult.OK)
            {
                noteBook.Text = File.ReadAllText(op.FileName.ToString());
            }
        }
        private void MenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            //save.RestoreDirectory = true;
            //save.DefaultExt = ".txt";
            //var res = save.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    File.WriteAllText(save.FileName, noteBook.Text);
            //}
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.RestoreDirectory = true;
            save.DefaultExt = ".txt";
            var res = save.ShowDialog();
            if (res == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, noteBook.Text);
            }
        }
        private void dayModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Linen;
            noteBook.BackColor = Color.Linen;
            noteBook.ForeColor = Color.Black;
        }
        private void nigthModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            noteBook.BackColor = Color.Black;
            noteBook.ForeColor = Color.White;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are You Sure?","EXIT",MessageBoxButtons.YesNo);
            if(res==DialogResult.Yes)
            Close();
        }
        private void noteBook_TextChanged(object sender, EventArgs e)
        {
            lineCount.Text = $"Line Count:{noteBook.Lines.Length}";
            simbolCount.Text = $"Simbol Count:{noteBook.TextLength}";
        }
        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            simbolCount.Visible = false;
            lineCount.Visible = false;
            r2.Visible = true;
            r1.Visible = false;
        }
        private void r2_CheckedChanged_1(object sender, EventArgs e)
        {
            simbolCount.Visible = true;
            lineCount.Visible = true;
            r1.Visible = true;
            r2.Visible = false;
        }
        private void radioNight1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            noteBook.BackColor = Color.Black;
            noteBook.ForeColor = Color.White;
            radioNight1.Visible = false;
            radioNight2.Visible = true;
        }

        private void radioNight2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Linen;
            noteBook.BackColor = Color.Linen;
            noteBook.ForeColor = Color.Black;
            radioNight1.Visible = true;
            radioNight2.Visible = false;
        }
    }
}
