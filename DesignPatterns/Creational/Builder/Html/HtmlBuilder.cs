namespace Builder.Html
{
    class HtmlBuilder
    {
        HtmlElement root = new HtmlElement();
        string RootName;

        public HtmlBuilder(string rootName)
        {
            RootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            root.Elements.Add(element);

            return this;
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HtmlElement{ Name = RootName };
        }
    }
}
