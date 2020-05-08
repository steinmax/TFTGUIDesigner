using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFTGUIDesigner.TFTControls
{
    public class TFTRectangle : TFTControl
    {
        public TFTRectangle(int x, int y, int w, int h, TFTCanvas canvas) : base(x, y, w, h, canvas)
        {

        }

        public override void Draw()
        {
            base.Draw();

            Rectangle rect = new Rectangle(X, Y, Width, Height);
            Pen pen = new Pen(BackgroundColor, BorderWith);
            graphics.DrawRectangle(pen, rect);
        }
    }
}
