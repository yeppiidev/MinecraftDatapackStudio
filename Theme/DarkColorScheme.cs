using System;
using System.Drawing;

namespace MinecraftDatapackStudio.Theme {
    public class DarkColorScheme : ColorScheme {
        public DarkColorScheme() {
            // do nothing
            String.ForeColor = Color.FromArgb(152, 195, 121);
            CommentLine.ForeColor = Color.FromArgb(157, 152, 152);
            Word.ForeColor = Color.FromArgb(97, 175, 239);
            Word2.ForeColor = Color.FromArgb(229, 192, 123);
            Editor.BackColor = Color.FromArgb(49, 58, 64);
            Editor.MarginBackColor = Color.FromArgb(67, 79, 87);
            Editor.ForeColor = Color.FromArgb(245, 245, 245);
            Editor.CaretForeColor = Color.White;
        }
    }
}