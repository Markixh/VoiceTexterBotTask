namespace VoiceTexterBot.Library.Services
{
    public class Operation : IOperation
    {
        public string Cnt(string message)
        {
            if (message != null)
            {
                return string.Concat(message.Length.ToString(), " ", Pref(message.Length));
            }
            else
                return "";
        }

        public string Sum(string message)
        {
            if (message != null)
            {
                var mes = message.Split(' ');
                int sum = 0;
                foreach (var word in mes)
                {
                    sum += Int32.Parse(word);
                }
                return string.Concat($"{message} Сумма чисел в сообщении:", sum);
            }
            else
                return "";
        }

        /// <summary>
        /// Склонение слова "символ", в зависимости от числа
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
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
    }
}
