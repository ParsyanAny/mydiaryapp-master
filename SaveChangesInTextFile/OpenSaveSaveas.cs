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
        OpenFileDialog op = new OpenFileDialog();
        SaveFileDialog save = new SaveFileDialog();

        public MyNoteBook()
        {
            InitializeComponent();
        }
        #region Menu
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // OpenFileDialog op = new OpenFileDialog();
            op.Filter = "TXT files|*.txt";
            op.InitialDirectory = @"\";//@"C:\";
            if (op.ShowDialog() == DialogResult.OK)
            {
                noteBook.Text = File.ReadAllText(op.FileName.ToString());
            }
        }
        private void SaveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (op.FileName != "")
            {
                File.WriteAllText(op.FileName, noteBook.Text);
                this.Text = "NotBook: Saved";
            }
            else if (save.FileName != "")
            {
                File.WriteAllText(save.FileName, noteBook.Text);
                this.Text = "NotBook: Saved";

            }
            else
            {
                MenuSaveas_Click(null, null);
            }
        }
        private void MenuSaveas_Click(object sender, EventArgs e)
        {
            save.RestoreDirectory = true;
            save.DefaultExt = ".txt";
            var res = save.ShowDialog();
            if (res == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, noteBook.Text);
                this.Text = "NotBook: Saved";
            }
        }
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JUST TRY IT!","INFO");
        }
        private void MenuExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save changes?","EXIT",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                SaveToolStripMenuItem_Click_1(null, null);
                MessageBox.Show("I did my job. You can go", "Exit", MessageBoxButtons.OK);
                this.Close();
            }
            else  Close();
        }
        #endregion
        #region RichTextBox Event
        private void NoteBook_TextChanges(object sender, EventArgs e)
        {
            this.Text = "NoteBook";
            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            lineCount.Text = $"Line Count:{noteBook.Lines.Length}";
            simbolCount.Text = $"Simbol Count:{noteBook.TextLength}";
        }
        #endregion
        #region CountersDesign
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
        #endregion

       
    }
}
