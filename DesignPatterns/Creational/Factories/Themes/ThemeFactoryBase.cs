namespace Factories.Themes
{
    internal class ThemeFactoryBase
    {
        public static ITheme CreateTheme(bool dark = false)
            => dark ? new DarkTheme() : new LigthTheme();
    }
}