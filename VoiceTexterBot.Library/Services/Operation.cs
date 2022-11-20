namespace VoiceTexterBot.Library.Services
{
    public class Operation : IOperation
    {
        public string Op(string message)
        {
            if (message != null)
            {
                return message.Length.ToString();
            }
            else
                return "";
        }
    }
}
