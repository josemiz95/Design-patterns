namespace Builder.Html
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        private const int _indentSize = 2;

        public HtmlElement()
        {
        }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException();
            Text = text ?? throw new ArgumentNullException();
        }

        private string ToStringImpl(int indentAmount)
        {
            var stringBuilder = new StringBuilder();
            var indent = new string(' ', _indentSize * indentAmount);

            stringBuilder.AppendLine($"{indent}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                stringBuilder.Append(new string(' ', _indentSize * (indentAmount + 1)));
                stringBuilder.AppendLine(Text);
            }

            foreach (var element in Elements)
            {
                stringBuilder.Append(element.ToStringImpl(indentAmount + 1));
            }

            stringBuilder.AppendLine($"{indent}</{Name}>");

            return stringBuilder.ToString();
        }

        public override string ToString() => ToStringImpl(0);
    }
}
