namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            bool result = true;
            uint i = 2;

            if (n > 1)
            {
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }

                    i++;
                }
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint result = 0;
            uint i = 2;

            if (n > 1)
            {
                while (i < n)
                {
                    while ((n % i) == 0)
                    {
                        n--;
                        i = 2;
                    }

                    i++;
                }

                result = n;
            }

            return result;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            // TODO 5-3. Implement the method that returns the sum of the latest _count_ prime numbers is (0, n] interval.
            throw new NotImplementedException();
        }
    }
}
