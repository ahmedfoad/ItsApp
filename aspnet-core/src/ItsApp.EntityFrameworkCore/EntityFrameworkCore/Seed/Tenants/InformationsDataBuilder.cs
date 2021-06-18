using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItsApp.Models;

namespace ItsApp.EntityFrameworkCore.Seed.Tenants
{
    public class InformationsDataBuilder
    {
        private readonly ItsAppDbContext _context;
        public InformationsDataBuilder(ItsAppDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            if (_context.Set<Information>().Any())
            {
                return;
            }

            var information1 = new Information { Title = "Title 1", Description = "Description 1", StepIndex = 1 };
            var information2 = new Information { Title = "Title 2", Description = "Description 2", StepIndex = 1 };
            var information3 = new Information { Title = "Title 3", Description = "Description 3", StepIndex = 1 };
            var information4 = new Information { Title = "Title 4", Description = "Description 4", StepIndex = 2 };
            var information5 = new Information { Title = "Title 5", Description = "Description 5", StepIndex = 3 };
            _context.Set<Information>().Add(information1);
            _context.Set<Information>().Add(information2);
            _context.Set<Information>().Add(information3);
            _context.Set<Information>().Add(information4);
            _context.Set<Information>().Add(information5);
            _context.SaveChanges();
        }

    }
}
