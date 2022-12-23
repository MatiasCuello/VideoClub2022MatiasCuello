using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly VideoClubDbContext context;
        public UnitOfWork(VideoClubDbContext context)
        {
            this.context = context;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
