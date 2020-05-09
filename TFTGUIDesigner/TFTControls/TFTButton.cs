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

        public TFTButton(TFTCanvas canvas) : base (canvas)
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

        public override void ApplyFromString(string input)
        {
            if (input.StartsWith("button"))
            {
                string[] snippets = input.Split(';');
                if (snippets.Length == 13)
                {
                    Name = snippets[1];
                    X = Convert.ToInt32(snippets[2]);
                    Y = Convert.ToInt32(snippets[3]);
                    Width = Convert.ToInt32(snippets[4]);
                    Height = Convert.ToInt32(snippets[5]);
                    BorderWith = Convert.ToInt32(snippets[6]);
                    Text = snippets[7].Replace("{se}", ";");
                    FontSize = float.Parse(snippets[8]);
                    string[] rgbsnippets = snippets[9].Split(',');
                    BackgroundColor = Color.FromArgb(Convert.ToInt32(rgbsnippets[0]), Convert.ToInt32(rgbsnippets[1]), Convert.ToInt32(rgbsnippets[2]));
                    rgbsnippets = snippets[10].Split(',');
                    ForegroundColor = Color.FromArgb(Convert.ToInt32(rgbsnippets[0]), Convert.ToInt32(rgbsnippets[1]), Convert.ToInt32(rgbsnippets[2]));
                    AutoSize = Convert.ToBoolean(snippets[11]);
                    DisplayText = snippets[12].Replace("{se}", ";");
                }
                else
                {
                    throw new Exception("Unable to parse");
                }
            }
            else
            {
                throw new Exception("Unable to parse");
            }
        }
        public override string ConvertToString()
        {
            return $"button;{Name};{X};{Y};{Width};{Height};{BorderWith};{Text.Replace(";", "{se}")};{FontSize};{BackgroundColor.R},{BackgroundColor.G},{BackgroundColor.B};{ForegroundColor.R},{ForegroundColor.G},{ForegroundColor.B};{AutoSize};{DisplayText.Replace(";", "{se}")}";
        }
    }
}