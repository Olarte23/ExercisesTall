namespace Exercise.Logic
{
    public static class Ex35
    {
        
        public static List<int> Factors(int N)
        {
            var factors = new List<int>();
            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    factors.Add(i);
                    N /= i;
                }

            }
            return factors;

        }
    }
    

}
