using System.Collections.Generic;

namespace EratosthenesProject
{
    public class Eratosthenes
    {
        private int N { get; set; }

        public void Init(int n)
        {
            if ((n > 0) && (n <= 50))
            {
                N = n;
            }
            else
            {
                N = 0;
            }
        }
        
        public List<int> GetSieve() // n - максимальное количество простых чисел.
        {
            if (N == 0)
            {
                return null;
            }

            List<int> simpleNumbers = new List<int>(); //создаем список из n элементов

            int number = 2; //первое простое число

            while (simpleNumbers.Count != N)
            {
                simpleNumbers.Add(number); // добавляем каждый элемент
                
                // производим выкол составных чисел
                for (int i = 0; i < simpleNumbers.Count; ++i)
                {
                    for (int j = 2; j < number; ++j)
                    {
                        simpleNumbers.Remove(simpleNumbers[i] * j); //составное число
                    }
                }
                number++; //переходим к след. элементу
            }

            return simpleNumbers; //возвращаем список
        }

        public string ToStr(List<int> numbers)
        {
            if (numbers == null)
            {
                return null;
            }

            string numbersStroke = "";

            //перебираем все элементы из списка numbers
            foreach (int num in numbers)
            {
                numbersStroke += $"{num}; "; //добавляем каждый элемент num"; " к строке
            }

            return numbersStroke;
        }
    }
}
