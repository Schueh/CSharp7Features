using System;

namespace CSharp7Features
{
    public class LocalFunctions
    {
        public void Foo()
        {
            var bar = Bar(1);
            Console.WriteLine(bar.a);
            Console.WriteLine(bar.b);

            (string a, string b) Bar(int i)
            {
                return ("abc", "def");
            }
        }
    }
}