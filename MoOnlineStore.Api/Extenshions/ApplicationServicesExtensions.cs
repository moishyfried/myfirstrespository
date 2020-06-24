using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MoOnlineStore.Api.Errors;
using MoOnlineStore.Core.Interfaces;
using MoOnlineStore.Presistene;
using MoOnlineStore.Presistene.DataBase;
using System.Linq;

namespace MoOnlineStore.Api.Extenshions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // services.AddScoped<IProductRespository, StoreRespository>();
             services.AddScoped(typeof(IGenericRepository<>),(typeof(GenericRepository<>)));
               services.Configure<ApiBehaviorOptions>(options => 
              {
               options.InvalidModelStateResponseFactory = ActionContext =>
               {
                 var errors = ActionContext.ModelState
                 .Where( e => e.Value.Errors.Count > 0)
                 .SelectMany(x => x.Value.Errors)
                 .Select(p => p.ErrorMessage).ToArray();

                 var errorResponse = new ApiValidationErrorResponse
                 {
                    Errors = errors
                 };
                 return new BadRequestObjectResult(errorResponse);
               };
              });
            return services;
        }
    }
}