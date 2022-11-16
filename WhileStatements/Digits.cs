namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;
            ulong var = 10;

            while (n > 0)
            {
                sum += n % var;
                n /= var;
            }

            return sum;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong multiply = 1;
            ulong var = 10;

            do
            {
                multiply *= n % var;
                n /= var;
            }
            while (n != 0);

            return multiply;
        }
    }
}
