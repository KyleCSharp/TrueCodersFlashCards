using System.Net.Http.Headers;
using TrueCodersFlashCards.Models;

namespace TrueCodersFlashCards
{
    public interface IFlashCardsRepo
    {
        public IEnumerable<FlashCards> GetAllFlashCards();
    }
}
