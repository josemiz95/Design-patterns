using System;
using System.Collections.Generic;
using Strategy.Comparer;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demo.Strategy();
            Demo.Comparer();
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

        public static void Comparer()
        {
            var people = new List<Person>();
            var comparer = new NameRelationalComparer();

            people.Sort(comparer);
        }
    }
}
