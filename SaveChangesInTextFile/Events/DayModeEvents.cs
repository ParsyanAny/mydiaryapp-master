using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveChangesInTextFile
{
    public partial class MyNoteBook : Form
    {
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
        private void radioNight1_CheckedChanged(object sender, EventArgs e)
        {
            nigthModeToolStripMenuItem_Click(null, null);
            radioNight1.Visible = false;
            radioNight2.Visible = true;
        }
        private void radioNight2_CheckedChanged(object sender, EventArgs e)
        {
            dayModeToolStripMenuItem_Click(null, null);
            radioNight1.Visible = true;
            radioNight2.Visible = false;
        }
    }
}
