namespace MethodOverloading
{
    public class Program
    {
        public static int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            var response = ""; //this is just and empty string for if the bool is false

            if(isTrue)
            {
                sum = num1 + num2;

                if (sum == 1 || sum == -1)
                {
                    response = $"{sum} dollar";
                }
                else
                {
                    response = $"{sum} dollars";
                }
            }            /* You could condense lines 20-31 into 1 line useing Ternary..example below
                          * response = (sum == 1 || sum == -1) ? $"{sum} dollar" : $"{sum} dollars"; */
            
            return response;
            
            
            
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(add(0, -1, true));

            Console.WriteLine(add(3, 2, true));
        }
    }
}
