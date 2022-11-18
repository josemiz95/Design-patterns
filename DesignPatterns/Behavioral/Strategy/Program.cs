using System;
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.Strategy();
        }
    }

    public static class Demo
    {
        public static void Strategy()
        {
            var markDown = new TextProcessor<MarkdownListStrategy>();
            markDown.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(markDown);

            var html = new TextProcessor<HtmlListStrategy>();
            html.AppendList(new[] { "foo", "bar", "baz" });
            Console.WriteLine(html);
        }
    }
}
