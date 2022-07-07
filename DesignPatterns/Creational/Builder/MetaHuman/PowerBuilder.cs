namespace Builder.MetaHuman
{
    public class PowerBuilder : MetaHumanBuilder
    {
        public PowerBuilder(MetaHuman metaHuman)
        {
            this.metaHuman = metaHuman;
        }

        public PowerBuilder HasPower(string power)
        {
            metaHuman.Power = power;
            return this;
        }

        public PowerBuilder HasEnergy(int energy)
        {
            metaHuman.Energy = energy;
            return this;
        }
    }
}
