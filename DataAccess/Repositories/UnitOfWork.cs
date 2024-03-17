using DataAccess.Data;
using Refine.Repositories.IRepository;

namespace Refine.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAsrRepository Asr { get; private set; }

        public IAnrpcRepository Anrpc { get; private set; }

        ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Asr=new AsrRepository(_db);
            Anrpc=new AnrpcRepository(_db);
        }
    }
}
