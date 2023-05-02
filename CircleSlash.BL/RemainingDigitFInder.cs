namespace CircleSlash.BL
{
    public class RemainingDigitFinder : IRemainingDigitFinder
    {
        public int CircleSlash(int n)
        {
            if (n == 1)
            { 
                return 1; 
            }

            if (n % 2 == 0)

            { 
                return 2 * CircleSlash(n / 2) - 1; 
            }

            else
            { 
                return 2 * CircleSlash((n - 1) / 2) + 1; 
            }
        }
    }
}