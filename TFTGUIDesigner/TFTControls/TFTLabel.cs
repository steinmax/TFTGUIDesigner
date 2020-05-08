using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFTGUIDesigner.TFTControls
{
    public class TFTLabel : TFTControl
    {
        public TFTLabel(int x, int y, int w, int h, TFTCanvas canvas) : base(x, y, w, h, canvas)
        {
            ForegroundColor = Color.White;
        }

        public override void Draw()
        {
            base.Draw();

            Pen pen = new Pen(ForegroundColor, BorderWith);
            graphics.DrawString(Text, new System.Drawing.Font(FontName, FontSize), pen.Brush, X, Y);
            Size size = Size.Truncate(graphics.MeasureString(Text, new System.Drawing.Font(FontName, FontSize)));
            Width = size.Width;
            Height = size.Height;
        }
    }
}
