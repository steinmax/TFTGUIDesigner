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
        public TFTLabel(TFTCanvas canvas) : base(canvas)
        {

        }
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

        public override void ApplyFromString(string input)
        {
            if (input.StartsWith("label"))
            {
                string[] snippets = input.Split(';');
                if (snippets.Length == 11)
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
            return $"label;{Name};{X};{Y};{Width};{Height};{BorderWith};{Text.Replace(";", "{se}")};{FontSize};{BackgroundColor.R},{BackgroundColor.G},{BackgroundColor.B};{ForegroundColor.R},{ForegroundColor.G},{ForegroundColor.B}";
        }
    }
}
