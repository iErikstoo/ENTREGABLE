using Microsoft.EntityFrameworkCore;

namespace ENTREGABLE.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
   

        {
            
        }
    }
}
