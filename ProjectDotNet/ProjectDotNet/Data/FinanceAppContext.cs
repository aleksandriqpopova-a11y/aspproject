using Microsoft.EntityFrameworkCore;
using ProjectDotNet.Models;

namespace ProjectDotNet.Data
{
    public class FinanceAppContext(DbContextOptions<FinanceAppContext> options) : Dbcontext(options)
    {
        DbSet<Expence>? Expences {  get; set; }
    }
}
