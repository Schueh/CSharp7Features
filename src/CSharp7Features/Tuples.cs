using System;

namespace CSharp7Features
{
    public class Tuples
    {
        public void Foo()
        {
            var message = GetMessage(Guid.NewGuid());
            Console.WriteLine(message.Item1); // subject
            Console.WriteLine(message.Item2); // body

            var message1 = GetMessage1(Guid.NewGuid());
            Console.WriteLine(message1.subject);
            Console.WriteLine(message1.body);

            var (body, subject) = GetMessage(Guid.NewGuid());
            Console.WriteLine(body);
            Console.WriteLine(subject);
        }

        public (string, string) GetMessage(Guid messageId)
        {
            string subject = "foo";
            string body = "bar";

            return (subject, body);
        }

        public (string subject, string body) GetMessage1(Guid messageId)
        {
            string messageSubject = "foo";
            string messageBody = "bar";

            return (messageSubject, messageBody);
        }
    }
}