using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFTGUIDesigner.TFTControls
{
    public class TFTButton : TFTControl
    {
        public bool AutoSize { get; set; } = false;
        public string DisplayText { get; private set; }
        public TFTButton(int x, int y, int w, int h, TFTCanvas canvas) : base(x, y, w, h, canvas)
        {

        }

        public override void Draw()
        {
            base.Draw();

            Font font = new Font(FontName, FontSize);
            Pen pen = new Pen(BackgroundColor, BorderWith);

            SizeF size = graphics.MeasureString(Text, font);
            if (AutoSize)
            {
                Width = Convert.ToInt32(size.Width);
                Height = Convert.ToInt32(size.Height);
                Rectangle rect = new Rectangle(X, Y, Width, Height);
                graphics.FillRectangle(pen.Brush, rect);
                pen = new Pen(ForegroundColor, BorderWith);
                graphics.DrawString(Text, font, pen.Brush, X, Y);
            }
            else
            {
                Rectangle rect = new Rectangle(X, Y, Width, Height);
                graphics.FillRectangle(pen.Brush, rect);

                string fittableText = "";
                int padding = Convert.ToInt32(graphics.MeasureString("... ", font).Width);
                int textWidth = Convert.ToInt32(graphics.MeasureString(Text, font).Width);
                pen = new Pen(ForegroundColor, BorderWith);

                if (textWidth < Width)
                {
                    graphics.DrawString(Text, font, pen.Brush, X, Y);
                    DisplayText = Text;
                }
                else
                {
                    bool finished = false;
                    for (int i = 0; i < Text.Length && !finished; i++)
                    {
                        fittableText = Text.Substring(0, Text.Length - i);

                        int tempwidth = Convert.ToInt32(graphics.MeasureString(fittableText, font).Width) + padding;

                        if (tempwidth < Width)
                            finished = true;
                    }
                    DisplayText = fittableText += "...";
                    graphics.DrawString(fittableText, font, pen.Brush, X, Y);
                }
            }
        }
    }
}