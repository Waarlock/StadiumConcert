using Microsoft.AspNetCore.Mvc.Rendering;

namespace StadiumConcert.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();


    }
}
