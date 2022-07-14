using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.Themes
{
    class ThemeFactory
    {
        public static ITheme CreateTheme(bool dark = false)
            => dark ? new DarkTheme() : new LigthTheme();
    }
}
