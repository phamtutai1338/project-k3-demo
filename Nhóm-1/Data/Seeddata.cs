using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace nhóm_1.Data
{
    public class Seeddata
    {
        public object Database { get; private set; }
        public object User { get; private set; }

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            if (applicationBuilder is null)
            {
                throw new ArgumentNullException(nameof(applicationBuilder));
            }

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<Seeddata>();

                context.Database.EnsyareCreated();
                if (!context.User.Any()) 
                { 
                
                
                }

            }
        }
    }
}
