namespace VoiceTexterBot.Library.Services
{
    public class Operation : IOperation
    {
        public string Op(string message)
        {
            if (message != null)
            {
                return string.Concat(message.Length.ToString(), " ", Pref(message.Length));
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
    }
}
