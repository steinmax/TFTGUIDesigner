using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFTGUIDesigner
{
    public partial class frmResizeCanvas : Form
    {
        public bool Success { get; set; } = false;
        public int Width { get; set; }
        public int Height { get; set; }
        public frmResizeCanvas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Success = false;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out int width) && int.TryParse(textBox2.Text, out int height))
            {
                Width = width;
                Height = height;
                Success = true;
                Close();
            }
            else
            {
                Success = false;
                Close();
            }
        }
    }
}
