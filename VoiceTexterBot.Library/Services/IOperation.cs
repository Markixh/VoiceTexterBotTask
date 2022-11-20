namespace VoiceTexterBot.Library.Services
{
    public interface IOperation
    {
        /// <summary>
        /// Операция подсчета суммы чисел в сообщении
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <returns></returns>
        string Sum(string message);

        /// <summary>
        /// Операция подсчета символов в сообщении
        /// </summary>
        /// <param name="message">сообщение</param>
        /// <returns></returns>
        string Cnt(string message);
    }
}
