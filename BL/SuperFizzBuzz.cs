using SuperFizzBuzz;
using System;


namespace SuperFizzBuzz
{
    public class SuperFizzBuzz : ISuperFizzBuzz
    {
        int _num1, 
            _num2, 
            _option;
        int[] _divisors;
        string[] _tokens = new string[3];        

        public SuperFizzBuzz(string num1, string num2, int option) 
        {
            _num1 = Int32.Parse(num1);
            _num2 = Int32.Parse(num2);
            _option = option;
            ClassicDefaultTokens();
        }

        public SuperFizzBuzz(string num1, string num2, int option, string[] divisors, string[] tokens)
        {
            _num1 = Int32.Parse(num1);
            _num2 = Int32.Parse(num2);
            _option = option;
            _divisors = Array.ConvertAll(divisors, item => int.Parse(item));            

            if (tokens is null)
                AdvanceDefaultTokens();
            else
                _tokens = tokens;
        }

        void ClassicDefaultTokens() 
        {
            _tokens[0] = "Fizz";
            _tokens[1] = "Buzz";
        }

        void AdvanceDefaultTokens()
        {
            _tokens[0] = "Frog";
            _tokens[1] = "Duck";
            _tokens[2] = "Chicken";            
        }

        public string[] RunClassic() 
        {
            int max, min;
            string[] result;

            max = Math.Max(_num1, _num2);
            min = Math.Min(_num1, _num2);

            result = new string[Math.Abs(max - min) + 1];

            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = (min % 3 == 0 && min % 5 == 0) ? _tokens[0] + _tokens[1] //FizzBuzz
                          : (min % 3 == 0) ? _tokens[0] //Fizz
                          : (min % 5 == 0) ? _tokens[1] //Buzz
                          : min.ToString();

                min = min + 1;
            }

            return result;
        }

        public string[] RunAdvance()
        {
            int max, min;
            string[] result;

            max = Math.Max(_num1, _num2);
            min = Math.Min(_num1, _num2);

            result = new string[Math.Abs(max - min) + 1];

            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = (min % _divisors[0] == 0 && min % _divisors[1] == 0 && min % _divisors[2] == 0) ? _tokens[0] + _tokens[1] + _tokens[2] //FrogDuckChicken or Custom Tokens
                          : (min % _divisors[0] == 0 && min % _divisors[1] == 0) ? _tokens[0] + _tokens[1] //FrogDuck
                          : (min % _divisors[1] == 0 && min % _divisors[2] == 0) ? _tokens[1] + _tokens[2] //DuckChicken
                          : (min % _divisors[0] == 0 && min % _divisors[2] == 0) ? _tokens[0] + _tokens[2] //FrogChicken
                          : (min % _divisors[0] == 0) ? _tokens[0] //Frog
                          : (min % _divisors[1] == 0) ? _tokens[1] //Duck
                          : (min % _divisors[2] == 0) ? _tokens[2] //Chicken
                          : min.ToString();

                min = min + 1;
            }

            return result;
        }
    }
}
