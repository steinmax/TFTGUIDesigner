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
        public TFTRectangle(TFTCanvas canvas) : base(canvas)
        {

        }
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

        public override void ApplyFromString(string input)
        {
            if (input.StartsWith("rectangle"))
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
            return $"rectangle;{Name};{X};{Y};{Width};{Height};{BorderWith};{Text.Replace(";", "{se}")};{FontSize};{BackgroundColor.R},{BackgroundColor.G},{BackgroundColor.B};{ForegroundColor.R},{ForegroundColor.G},{ForegroundColor.B}";
        }
    }
}
