namespace Flow_control_and_function
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            
            int[] testCases = { 2, 5, 7 };

            Console.WriteLine("Testing with sample data:");
            foreach (var n in testCases)
            {
                Console.WriteLine($"\nFor n = {n}:");

                
                double s1 = CalculateS1(n);
                double s2 = CalculateS2(n);
                double s5 = CalculateS5(n);
                double s6 = CalculateS6(n);
                double s7 = CalculateS7(n);

                
                double expectedS1 = n == 2 ? 0.8 : (n == 5 ? 0.85627705628 : (n == 7 ? 0.85243090243 : 0));
                double expectedS2 = n == 2 ? 1 : (n == 5 ? 0.066666666667 : (n == 7 ? 0.13015873016 : 0));
                double expectedS5 = n == 2 ? 0.25 : (n == 5 ? 0.39166666667 : (n == 7 ? 0.37976190476 : 0));
                double expectedS6 = n == 2 ? 0.6666666667 : (n == 5 ? 0.8 : (n == 7 ? 0.7880952381 : 0));
                double expectedS7 = n == 2 ? 5 : (n == 5 ? 7.2666666667 : (n == 7 ? 7.38095238095 : 0));

                
                Console.WriteLine($"S1 = {s1:F5} (Expected: {expectedS1})");
                Console.WriteLine($"S2 = {s2:F5} (Expected: {expectedS2})");
                Console.WriteLine($"S5 = {s5:F5} (Expected: {expectedS5})");
                Console.WriteLine($"S6 = {s6:F5} (Expected: {expectedS6})");
                Console.WriteLine($"S7 = {s7:F5} (Expected: {expectedS7})");
            }

            /*
            Console.Write("\nEnter an integer n: ");
            int userN = int.Parse(Console.ReadLine());
            Console.WriteLine($"S1 = {CalculateS1(userN):F10}");
            Console.WriteLine($"S2 = {CalculateS2(userN):F10}");
            Console.WriteLine($"S5 = {CalculateS5(userN):F10}");
            Console.WriteLine($"S6 = {CalculateS6(userN):F10}");
            Console.WriteLine($"S7 = {CalculateS7(userN):F10}");*/
        }

        static double CalculateS1(int n)
        {
            double sum = 0;
            double totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
                totalSum += Math.Pow(-1, i + 1) / sum;
            }
            return totalSum;
        }

        static double CalculateS2(int n)
        {
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(-2, i) / Factorial(i);
            }
            return sum;
        }

        static double CalculateS5(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i + 1) / (2 * i);
            }
            return sum;
        }

        static double CalculateS6(int n)
        {
            double sum = 0;
            double totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                totalSum += Math.Pow(-1, i + 1) / sum;
            }
            return totalSum;
        }

        static double CalculateS7(int n)
        {
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(2, i) / Factorial(i);
            }
            return sum;
        }

        static double Factorial(int num)
        {
            double result = 1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
