using Telegram.Bot;
using Telegram.Bot.Types;

namespace VoiceTexterBot.Library.Controllers
{
    /// <summary>
    /// контроллер обработки сообщений, которые не являются командой, текстом или аудиосообщением
    /// </summary>
    public class DefaultMessageController
    {
        private readonly ITelegramBotClient _telegramClient;

        public DefaultMessageController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
            await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено сообщение не поддерживаемого формата", cancellationToken: ct);
        }
    }
}