using Microsoft.EntityFrameworkCore;
using StadiumConcert.Data.Entities;

namespace StadiumConcert.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly int EntranceId = 5000;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            // await _context.Database.EnsureCreatedAsync();
            _context.Database.Migrate();
            await CheckTicketsAsync();
            await CheckEntrancesAsync();

        }

        private async Task CheckEntrancesAsync()
        {

            {
                if (!_context.Entrances.Any())
                {
                    _context.Entrances.Add(new Entrance { Description = "Norte" });
                    _context.Entrances.Add(new Entrance { Description = "Sur" });
                    _context.Entrances.Add(new Entrance { Description = "Oriental" });
                    _context.Entrances.Add(new Entrance { Description = "Occidental" });
                    await _context.SaveChangesAsync();
                }
            }
        }

        private async Task CheckTicketsAsync()
        {

            if (!_context.Tickets.Any())
            {
                Entrance entrance = _context.Entrances.FirstOrDefault(c => c.Id == 1);

                for (int i = 1; i <= EntranceId; i++)
                {
                    _context.Tickets.Add(new Ticket { WasUsed = false, Entrance = entrance });
                    await _context.SaveChangesAsync();
                }


            }



            //if (!_context.Tickets.Any())
            //{
            //    int k = 0;

            //    for (k = 0; k <= 5000; k++)
            //    {
            //        _context.Tickets.Add(new Ticket { Id = k });
            //    }
            //    await _context.SaveChangesAsync();
            //}
        }
    }
}
