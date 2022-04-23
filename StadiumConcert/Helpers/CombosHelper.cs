using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StadiumConcert.Data;

namespace StadiumConcert.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _context;

        public CombosHelper(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync()
        {
            List<SelectListItem> list = await _context.Entrances.Select(c => new SelectListItem
            {
                Text = c.Description,
                Value = c.Id.ToString()
            }).ToListAsync();

            list.Insert(0, new SelectListItem { Text = "Seleccione una Entrada.", Value = "0" });

            return list;
        }
    }
}
