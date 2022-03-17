using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNTier.Business.Interfaces;
using ToDoAppNTier.Business.Services;
using ToDoAppNTier.DataAccess.Contexts;
using ToDoAppNTier.DataAccess.UnitOfWork;

namespace ToDoAppNTier.Business.DependencyResolvers.Microsoft
{
    //Burada normalde startup içinde yazdığımız IServiceCollection'u genişleterek services uzantılarını kullanmayı sağlıyoruz.
    //Bunu static yapma sebebimiz genişlettikten sonra farklı yerlerde de kullanabilmemiz.
    //Diğer türlü ilgili yerde instance almamız gerekirdi.

    //Bunu services.AddDependencies(); yazarak, using ekleyerek startup içinde çağırıyoruz.
    public static class DependencyExtention
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUow, Uow>();
            services.AddScoped<IWorkService, WorkService>();
            services.AddDbContext<TodoContext>(opt =>
            {
                opt.UseSqlServer("Server=(localdb)\\mssqllocaldb; database=TodoDb; integrated security=true");
            });
        }
    }
}
