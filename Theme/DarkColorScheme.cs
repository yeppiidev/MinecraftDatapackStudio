using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftDatapackStudio.Theme {
    public class DarkColorScheme : ColorScheme {
        public DarkColorScheme() {
            // do nothing
            String.ForeColor = Color.FromArgb(152, 195, 121);
            CommentLine.ForeColor = Color.FromArgb(127, 132, 142);
            Word.ForeColor = Color.FromArgb(97, 175, 239);
            Word2.ForeColor = Color.FromArgb(229, 192, 123);
            Editor.BackColor = Color.FromArgb(54, 69, 79);
            Editor.ForeColor = Color.FromArgb(245, 245, 245);
        }
    }
}