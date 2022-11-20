using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using VoiceTexterBot.Library.Services;

namespace VoiceTexterBot.Library.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly IOperation _operation;

        public TextMessageController(ITelegramBotClient telegramBotClient, IOperation operation)
        {
            _telegramClient = telegramBotClient;
            _operation = operation;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            switch (message.Text)
            {
                case "/start":

                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"<b>  Наш бот подсчитывает символы в тексте</b>", cancellationToken: ct, parseMode: ParseMode.Html);
                    break;

                default:
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Отправлено {_operation.Op(message.Text)} символов", cancellationToken: ct);
                    break;
            }
        }
    }
}
