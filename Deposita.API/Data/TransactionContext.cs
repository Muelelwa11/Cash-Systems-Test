using Microsoft.EntityFrameworkCore;
using Deposita.API.Models;

namespace Deposita.API.Data
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}