using System;

namespace CSharp7Features
{
    public class PatternMatching
    {
        /* Pattern Matching */
        /* Form einer Variable prüfen und direkt Informationen extrahieren */

        public void IsExpression(object something)
        {
            if (something is null) // Constant pattern
            {
                // ...
            }

            if (something is int i) // Type pattern
            {
                Console.WriteLine(i);
            }

            // Kombination von Patterns und Out Variable
            if (something is int j || (something is string s && int.TryParse(s, out j)))
            {
                Console.WriteLine(j);
            }
        }

        public void SwitchExpression(User user)
        {
            switch (user)
            {
                case Administrator admin when admin.IsEnabled:
                    // do something with admin object
                    break;
                case Reporter reporter when reporter.HasPermission():
                    // do something with reporter object
                    break;
                case null:
                    throw new ArgumentNullException(nameof(user));
                default:
                    throw new ArgumentException("Unknown user type");
            }
        }

        public class Administrator : User
        {
            
        }

        public class Reporter : User
        {
            public bool HasPermission()
            {
                return true;
            }
        }

        public abstract class User
        {
            public bool IsEnabled { get; set; }
        }
    }
}