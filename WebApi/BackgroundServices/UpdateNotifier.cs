
using Application.Repositories.Abstract;
using Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;

namespace WebApi.BackgroundServices
{
    public class UpdateNotifier : IHostedService
    {
        private readonly AppDbContext _context;
        private Timer? _timer;

        public UpdateNotifier(AppDbContext context)
        {
            _context = context;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Background Service started...");
            _timer = new Timer(Check, null, 10, 2500);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Dispose();
            Console.WriteLine("Background Service stopped...");
            return Task.CompletedTask;
        }


        public async void Check(object? obj)
        {
            Console.WriteLine("---------START----------");
            var vcs = _context.Vacancies;
            var last20 = new List<Vacancy>();
            await vcs.ForEachAsync(x =>
            {
                if (x.UpdatedDate.Value.AddSeconds(5) >= DateTime.Now)
                {
                    Console.WriteLine($"Id: {x.Id}");
                    Console.WriteLine($"Name: {x.Name}");
                    Console.WriteLine($"Description: {x.Description}");
                    last20.Add(x);
                }
            });
            Console.WriteLine("----------END-----------");
        }
    }
}
