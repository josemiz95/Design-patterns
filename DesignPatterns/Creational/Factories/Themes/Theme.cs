using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.Themes
{
    class LigthTheme : ITheme
    {
        public string TextColor => "black";

        public string BgColor => "white";

        public override string ToString() => "Ligth";
    }

    class DarkTheme : ITheme
    {
        public string TextColor => "white";

        public string BgColor => "dark gray";

        public override string ToString() => "Dark";
    }
}
