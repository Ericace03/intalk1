using System;
using System.Reflection;
using teszt2.Controllers;

namespace teszt2.Models
{
	public class CounterModel
	{
        public int number1 { get; set; }
        public int number2 { get; set; }
        public string operation { get; set; }

        public string calculate()
        {
            int result = 0;
            string message = "";

            switch (operation)
            {
                case "add":
                    result = number1 + number2;
                    message = $"A két szám összege: {result}";
                    break;
                case "subtract":
                    result = number1 - number2;
                    message = $"A két szám különbsége: {result}";
                    break;
                case "multiply":
                    result = number1 * number2;
                    message = $"A két szám szorzata: {result}";
                    break;
                case "divide":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        message = $"A két szám hányadosa: {result}";
                    }
                    else
                    {
                        message = "Nullával nem lehet osztani!";
                    }
                    break;
                default:
                    message = "Érvénytelen művelet!";
                    break;
            }
        return message;
        }
	}
}

