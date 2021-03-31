using Business.Concrete;
using Business.Interfaces;
using Business.ValidationRules.FluentValidation;
using DataAccess.Concrete.EfCore.Repositories;
using DataAccess.Interfaces;
using Entities.DTOs.ProductDto;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolves.MicrosoftIoc
{
    public static  class CustomExtension
    {
        public static void AddDependenceis(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));//IGenericServisi görünce GenericManagerı örnekle
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepositories<>));

            services.AddScoped<IProductDal, EfProductRepositories>();
            services.AddScoped<IProductService, ProductManager>();

            services.AddScoped<IAppUserDal, EfAppUserRepositories>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<IAppRoleDal, EfAppRoleRepositories>();
            services.AddScoped<IAppRoleService, AppRoleManager>();

            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepositories>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();

            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();
        }
    }
}
