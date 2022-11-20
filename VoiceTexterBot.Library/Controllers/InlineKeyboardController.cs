using Telegram.Bot;
using Telegram.Bot.Types;

namespace VoiceTexterBot.Library.Controllers
{
    public class InlineKeyboardController
    {        
        private readonly ITelegramBotClient _telegramClient;

        public InlineKeyboardController(ITelegramBotClient telegramBotClient)
        {
            _telegramClient = telegramBotClient;
        }

        public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
        {
            if (callbackQuery?.Data == null)
                return;

            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, "Отправьте текст для подсчета количества символов сообщения или суммы чисел", cancellationToken: ct);
        }
    }
}