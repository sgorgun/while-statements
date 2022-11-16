namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            uint sum = 0;
            uint i = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;

                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            uint sum = 0;
            uint i = 0;
            uint a = 13;
            uint r = 3;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;

                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            uint count = 0;
            uint i = 0;

            while (a <= maxTerm)
            {
                a *= r;
                count++;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            uint count = 0;
            uint myCount = 0;
            uint i = 1;

            while (i <= n)
            {
                while (a < minTerm)
                {
                    a *= r;
                    i++;
                    myCount++;
                }

                i++;
                count = n - myCount;
            }

            return count;
        }
    }
}
