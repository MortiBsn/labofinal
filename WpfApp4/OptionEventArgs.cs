using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp4
{
    public class OptionEventArgs
    {
        public OptionEventArgs(Color backgroundColor, int fontSize)
        {
            BackgroundColor = backgroundColor;
            FontSize = fontSize;
        }

        public Color BackgroundColor { get; }
        public int FontSize { get; }
    }
}
