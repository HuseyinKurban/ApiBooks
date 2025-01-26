using ApiBooks.BusinessLayer.Abstract;
using ApiBooks.BusinessLayer.Concrete;
using ApiBooks.DataAccessLayer.Abstract;
using ApiBooks.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiBooks.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IBookDal, EfBookDal>();

            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();

            services.AddScoped<IWriterService, WriterManager>();
            services.AddScoped<IWriterDal, EfWriterDal>();

            services.AddScoped<IQuoteService, QuoteManager>();
            services.AddScoped<IQuoteDal, EfQuoteDal>();

        }
    }
}
