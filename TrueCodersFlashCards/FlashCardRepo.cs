using Dapper;
using System.Data;
using TrueCodersFlashCards.Models;


namespace TrueCodersFlashCards
{
    public class FlashCardRepo : IFlashCardsRepo
    {
        private readonly IDbConnection _conn;
        
        public FlashCardRepo(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<FlashCards> GetAllFlashCards()
        {
            return _conn.Query<FlashCards>("SELECT * FROM FLASHCARDS");
        }
    }
}
