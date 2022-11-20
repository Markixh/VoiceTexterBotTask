using System.Linq.Expressions;

namespace VoiceTexterBot.Library.Services
{
    public class Operation : IOperation
    {
        public string Op(string message)
        {
            if (message != null)
            {
                if (!IsOperation(message))
                    return string.Concat(message.Length.ToString(), " ", Pref(message.Length));
                else
                {
                    var mes = message.Split(' ');
                    int sum = 0;
                    foreach (var word in mes)
                    {
                        sum += Int32.Parse(word);
                    }
                    return string.Concat($"{message} Сумма чисел в сообщении:", sum);
                }
            }
            else
                return "";
        }

        private string Pref(int n)
        {
            if (n <= 20)
            {
                switch (n)
                {
                    case 1: return "символ";
                    case 3:
                    case 4:
                    case 2: return "символа";
                    default: return "символов";

                }
            }
            else
            {
                switch (n % 10)
                {
                    case 1: return "символ";
                    case 3:
                    case 4:
                    case 2: return "символа";
                    default: return "символов";

                }
            }
        }

        private bool IsOperation(string message)
        {
            try
            {
                var mes = message.Split(' ');
                int sum = 0;
                foreach(var word in mes)
                {
                    sum += Int32.Parse(word);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
