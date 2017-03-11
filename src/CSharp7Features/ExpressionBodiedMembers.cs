namespace CSharp7Features
{
    public class ExpressionBodiedMembers
    {
        public class Person
        {
            public Person(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

            private string _name;
            public string Name
            {
                get => !string.IsNullOrWhiteSpace(_name) ? _name : "undefined";
                set => _name = value;
            }
        }
    }
}