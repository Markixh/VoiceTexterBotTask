namespace VoiceTexterBot.Library.Services
{
    public class Operation : IOperation
    {
        /// <summary>
        /// Подсчет символов в тексте или суммы чисел, в зависимости от формата введенного сообщения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Проверка типа сообщения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
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
