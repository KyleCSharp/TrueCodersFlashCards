using Microsoft.AspNetCore.Mvc;

namespace TrueCodersFlashCards.Controllers
{
    public class FlashCardsController : Controller
    {
       
        private readonly IFlashCardsRepo repo;

        public FlashCardsController(IFlashCardsRepo repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllFlashCards();

            return View(products);
        }

    }
}
