using firstt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace firstt.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var teamMembers = GetTeamMembers(); // Отримуємо список членів команди
            return View(teamMembers); // Передаємо список у представлення
        }

        private List<TeamMembers> GetTeamMembers() // Змінено на приватний метод
        {
            return new List<TeamMembers>
            {
                new TeamMembers { Name = "Олександр", Position = "CEO", Description = "Керівник компанії з 10-річним досвідом у сфері IT." },
                new TeamMembers { Name = "Марія", Position = "CTO", Description = "Технічний директор, спеціаліст з розробки програмного забезпечення." },
                new TeamMembers { Name = "Іван", Position = "UX/UI Designer", Description = "Дизайнер з великим досвідом у створенні зручних інтерфейсів." }
            };
        }
    }
}
