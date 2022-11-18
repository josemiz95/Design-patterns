namespace Strategy.Comparer
{
    using System;
    using System.Collections.Generic;

    public sealed class NameRelationalComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (ReferenceEquals(null, y)) return 1;
            if (ReferenceEquals(null, x)) return -1;

            return string.Compare(x.Name, y.Name,
                StringComparison.Ordinal);
        }
    }
}
