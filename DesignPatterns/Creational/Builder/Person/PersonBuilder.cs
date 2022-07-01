namespace Builder.Person
{
    public abstract class PersonBuilder
    {
        protected Person person = new Person();

        public Person Build() => person;
    }
}
