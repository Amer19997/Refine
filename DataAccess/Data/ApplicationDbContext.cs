using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RefineModels.Models.ANRPC;
using RefineModels.Models.ASR;
using RefineModels.Models.Identity;


namespace DataAccess.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<AsrTable1> AsrTable1 { get; set; }
    public DbSet<AsrTable2> AsrDistillationProducts { get; set; }
    public DbSet<AsrTable3> AsrTable3 { get; set; }
    public DbSet<AsrTable4> AsrTable4 { get; set; }
    public DbSet<AsrTable5> AsrTable5 { get; set; }

    public DbSet<AnrpcTable1> AnrpcTable1 { get; set; }
    public DbSet<AnrpcTable2> AnrpcTable2 { get; set; }
    public DbSet<AnrpcTable3> AnrpcTable3 { get; set; }
    public DbSet<AnrpcTable4> AnrpcTable4 { get; set; }
}
}
