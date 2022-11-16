using Microsoft.EntityFrameworkCore;

namespace GLC.EF
{
    public class GLCDbContext : DbContext
    {
        public GLCDbContext(DbContextOptions<GLCDbContext> options) : base(options)
        {

        }
    }
}
