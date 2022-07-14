using System;
using System.Collections.Generic;
using System.Text;

namespace Factories.Themes
{
    public interface ITheme
    {
        public string TextColor { get; }
        public string BgColor { get; }
    }
}
