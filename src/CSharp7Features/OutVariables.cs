namespace CSharp7Features
{
    public class OutVariables
    {
        public void Foo()
        {
            /* --- Out Variablen --- */

            // Vorher
            int i;
            if (int.TryParse("123", out i))
            {
                // i = 123
            }
            else
            {
                // i = 0
            }

            // Nachher
            if (int.TryParse("123", out int j))
            {
                // j = 123
            }
            else
            {
                // j = 0
            }


            if (int.TryParse("123", out var k))
            {

            }

            if (int.TryParse("123", out _))
            {

            }
        }
    }
}