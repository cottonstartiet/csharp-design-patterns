namespace DesignPatterns.Builder
{
    internal class BuilderPattern
    {
        public void Demo()
        {
            Person person = new Person.Builder()
                .SetFirstName("John")
                .SetLastName("Doe")
                .SetAge(30)
                .Build();

            Console.WriteLine($"Person: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        private Person(Builder builder)
        {
            FirstName = builder.FirstName;
            LastName = builder.LastName;
            Age = builder.Age;
        }

        public class Builder
        {
            public string? FirstName { get; private set; }
            public string? LastName { get; private set; }
            public int Age { get; private set; }

            public Builder SetFirstName(string firstName)
            {
                FirstName = firstName;
                return this;
            }

            public Builder SetLastName(string lastName)
            {
                LastName = lastName;
                return this;
            }

            public Builder SetAge(int age)
            {
                Age = age;
                return this;
            }

            public Person Build()
            {
                return new Person(this);
            }
        }
    }
}
