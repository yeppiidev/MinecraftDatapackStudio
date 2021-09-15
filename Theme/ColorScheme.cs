using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftDatapackStudio.Theme {
    public class ColorScheme {
        public ThemeElement.CommentLine CommentLine = new ThemeElement.CommentLine();
        public ThemeElement.Word Word = new ThemeElement.Word();
        public ThemeElement.Word2 Word2 = new ThemeElement.Word2();
        public ThemeElement.String String = new ThemeElement.String();
        public ThemeElement.Editor Editor = new ThemeElement.Editor();

        public ColorScheme() {
            // Constructor for subclasses
        }
    }

    public class ThemeElement {
        public class Editor {
            public Color ForeColor;
            public Color BackColor;
        }

        public class String {
            public Color ForeColor;
            public Color BackColor;
        }

        public class Word2 {
            public Color ForeColor;
            public Color BackColor;
        }

        public class Word {
            public Color ForeColor;
            public Color BackColor;
        }

        public class CommentLine {
            public Color ForeColor;
            public Color BackColor;
        }
    }
}
