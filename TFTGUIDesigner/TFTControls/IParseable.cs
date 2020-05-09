using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFTGUIDesigner.TFTControls
{
    interface IParseable
    {
        string ConvertToString();
        void ApplyFromString(string input);
    }
}
