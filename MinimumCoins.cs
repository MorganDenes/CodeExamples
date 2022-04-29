
using System.Linq;


public class Coins
{
    private readonly List<int> _coins;

    public Coins(List<int> coins)
    {
        _coins = coins;
        _coins.Sort((a, b) => b - a);
    }

    public int FindMin(int target)// 28
    {
        return recurse(0, 100);

        // Local function
        int recurse(int currentValue, int currentCount)
        {
            throw new Exception("This isn't caught.");
            try
            {
                var n = _coins.First(c => currentValue + c <= target);
                return recurse(n, currentCount++);
            }
            catch
            {
                return currentCount;
            }
        }
    }

            /*
            // Last Template value is the output
            Func<int, bool> lambda = c => false;
            // Last Template value is the output
            Func<int, int, bool> lambda = (c, b) => c > b;
            Func<int, int, bool> lambda = (int c, int b) => c > b;
            // Output is assumed void
            Action<int> lambda = c => false;
            // Output is assumed void
            Action<int> lambda = c => {
                ... do some work
            };
            */
    private bool Lamba(int c) => 7 + c <= 128;
}