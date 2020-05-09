using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFTGUIDesigner.TFTControls
{
    public class TFTCanvas
    {
        public Panel Canvas { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        private List<TFTControl> TFTControls = new List<TFTControl>();

        public TFTCanvas(Panel canvas)
        {
            Canvas = canvas;
            Height = canvas.Height;
            Width = canvas.Width;
        }

        public void AddControl(TFTControl con)
        {
            TFTControls.Add(con);
        }

        public void RemoveControl(TFTControl con)
        {
            if (TFTControls.Contains(con))
            {
                TFTControls.Remove(con);
                RedrawControls();
            }
        }

        public TFTControl[] GetControls()
        {
            return TFTControls.ToArray();
        }

        public void RedrawControls()
        {
            Canvas.CreateGraphics().Clear(Color.Black);
            foreach (TFTControl con in TFTControls)
            {
                con.Draw();
            }
        }

        public string GetStringLayout()
        {
            string result = $"{Height};{Width}";

            foreach (TFTControl control in TFTControls)
            {
                result += "~" + control.ConvertToString();
            }

            return result;
        }

        public void ApplyFromFile(string path, Panel canvas)
        {
            TFTControls.Clear();
            canvas.CreateGraphics().Clear(Color.Black);
            if (File.Exists(path))
            {
                Canvas = canvas;
                string raw = File.ReadAllText(path);
                string[] snippes = raw.Split('~');
                Height = Convert.ToInt32(snippes[0].Split(';')[0]);
                Width = Convert.ToInt32(snippes[0].Split(';')[1]);

                for (int i = 1; i < snippes.Length; i++)
                {
                    if (snippes[i].StartsWith("rectangle"))
                    {
                        TFTRectangle rect = new TFTRectangle(this);
                        rect.ApplyFromString(snippes[i]);
                    }
                    else if (snippes[i].StartsWith("label"))
                    {
                        TFTLabel lbn = new TFTLabel(this);
                        lbn.ApplyFromString(snippes[i]);
                    }
                    else if(snippes[i].StartsWith("button"))
                    {
                        TFTButton btn = new TFTButton(this);
                        btn.ApplyFromString(snippes[i]);
                    }
                }
                RedrawControls();
            }
            else
            {
                throw new Exception("File not found");
            }
        }
    }
}
