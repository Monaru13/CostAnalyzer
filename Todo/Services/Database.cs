using System.Collections.Generic;
using Todo.Models;

namespace Todo.Services
{
    public class Database
    {
        public IEnumerable<CostItem> GetItems() => new[]
        {
            new CostItem()
            {
                Cost = 12.59m,
                Description = "Biedronka - Kefir Biedronka - KefirBi edronka - KefirBiedr onka - KefirB iedronka - Kefir Biedro nka - Kefir",
                Tags = new string[] {"Zakupy", "Jedzenie"}
            },
            new CostItem()
            {
                Cost = 1023.23m,
                Description = "Biedronka - Kefir",
                Tags = new string[] {"Zakupy", "Jedzenie"}
            },
            new CostItem()
            {
                Cost = 12.5m,
                Description = "Biedronka - Kefir",
                Tags = new string[] {"Zakupy", "Jedzenie"}
            }
        };
    }
}