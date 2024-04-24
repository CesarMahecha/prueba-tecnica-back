using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace login.Context
{
    public class AplicattionDbcontext : IdentityDbContext
    {
        public AplicattionDbcontext(DbContextOptions options) : base(options)
        {
        }
    }
}
