using System;
using System.Collections.Generic;
using System.Drawing;
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
    }
}
