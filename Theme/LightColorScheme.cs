using System;
using System.Drawing;

namespace MinecraftDatapackStudio.Theme {
    public class LightColorScheme : ColorScheme {
        public LightColorScheme() {
            // do nothing
            String.ForeColor = Color.FromArgb(163, 21, 21);
            CommentLine.ForeColor = Color.FromArgb(0, 128, 0); ;
            Word.ForeColor = Color.Blue;
            Word2.ForeColor = Color.Blue;
            Editor.BackColor = Color.White;
            Editor.MarginBackColor = Color.Gainsboro;
            Editor.ForeColor = Color.Black;
            Editor.CaretForeColor = Color.Black;
        }
    }
}