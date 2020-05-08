using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFTGUIDesigner.TFTControls
{
    public abstract class TFTControl
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Width { get; set; } = 100;
        public int Height { get; set; } = 50;
        public int BorderWith { get; set; } = 3;
        public string Text { get; set; } = "";
        public Graphics graphics { get; set; }
        public Color BackgroundColor { get; set; } = Color.White;
        public Color ForegroundColor { get; set; } = Color.Black;
        public abstract void Draw();
        public TFTControl(TFTCanvas canvas)
        {
            graphics = canvas.Canvas.CreateGraphics();
            canvas.AddControl(this);
        }
    }
}
