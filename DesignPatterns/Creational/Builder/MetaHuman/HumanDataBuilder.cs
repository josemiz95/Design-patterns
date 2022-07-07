using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.MetaHuman
{
    public class HumanDataBuilder :MetaHumanBuilder
    {
        public HumanDataBuilder(MetaHuman metaHuman)
        {
            this.metaHuman = metaHuman;
        }

        public HumanDataBuilder Called(string name)
        {
            metaHuman.Name = name;
            return this;
        }

        public HumanDataBuilder Live(string address)
        {
            metaHuman.Address = address;
            return this;
        }
    }
}
