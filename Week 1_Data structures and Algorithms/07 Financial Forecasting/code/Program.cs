class Program
{
    public static Dictionary<int, double> memo = new Dictionary<int, double>();
    
    public static double calcFutureValue(double principal, double rate, int years)
    {
        if (memo.ContainsKey(years))
            return memo[years];

        if (years == 0)
            return principal;

        double result = calcFutureValue(principal * (1 + rate), rate, years - 1);
        memo[years] = result;
        return result;
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter the initial amount : ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the annual growth rate (decimal) : ");
        double growthRate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter the number of years : ");
        int years = int.Parse(Console.ReadLine());
        
        double futureValue = calcFutureValue(principal, growthRate, years);
        Console.WriteLine($"The future amount : {futureValue:F2}");
        
        Console.Beep();
        
    }
}