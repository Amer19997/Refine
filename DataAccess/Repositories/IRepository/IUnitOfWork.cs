namespace Refine.Repositories.IRepository
{
    public interface IUnitOfWork
    {
        IAsrRepository Asr {  get; }
        IAnrpcRepository Anrpc { get; }
    }
}
