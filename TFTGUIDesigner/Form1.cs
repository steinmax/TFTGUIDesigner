using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFTGUIDesigner.TFTControls;

namespace TFTGUIDesigner
{
    public partial class Form1 : Form
    {
        TFTCanvas TFTCan;
        public Form1()
        {
            InitializeComponent();
            TFTCan = new TFTCanvas(pnCanvas);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTestControlRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TFTRectangle rect = new TFTRectangle(10, 10, 50, 100, TFTCan);
            AddControl(rect);
        }

        public void AddControl(TFTControl con)
        {
            TFTCan.AddControl(con);
            TFTCan.RedrawControls();
        }
    }
}
