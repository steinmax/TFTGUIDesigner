using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFTGUIDesigner.TFTControls
{
    class TFTRectangle : TFTControl
    {
        public TFTRectangle(int x, int y, int w, int h, TFTCanvas canvas): base(canvas)
        {
            X = x;
            Y = y;
            Width = w;
            Height = h;
        }

        public override void Draw()
        {
            Rectangle rect = new Rectangle(X, Y, Width, Height);
            Pen pen = new Pen(BackgroundColor, BorderWith);
            graphics.DrawRectangle(pen, rect);
        }
    }
}
