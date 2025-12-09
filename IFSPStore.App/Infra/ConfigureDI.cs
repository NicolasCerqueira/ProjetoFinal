using AutoMapper;
using IFSPStore.App.Cadastros;
using IFSPStore.App.Models;
using IFSPStore.App.Outros;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace IFSPStore.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureService()
        {
            var dbConfigFile = "Base/Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);

            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                });
            // Repositories
            services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            services.AddScoped<IBaseRepository<Funcionario>, BaseRepository<Funcionario>>();
            services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            services.AddScoped<IBaseRepository<Carro>, BaseRepository<Carro>>();
            services.AddScoped<IBaseRepository<Locacao>, BaseRepository<Locacao>>();
            services.AddScoped<IBaseRepository<SaleItem>, BaseRepository<SaleItem>>();

            // Services
            services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();//se der bosta comente isso 03/12
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            services.AddScoped<IBaseService<Carro>, BaseService<Carro>>();
            services.AddScoped<IBaseService<Locacao>, BaseService<Locacao>>();
            services.AddScoped<IBaseService<SaleItem>, BaseService<SaleItem>>();

            //Formularios
            services.AddTransient<Login, Login>();
            services.AddTransient<CategoryForm, CategoryForm>();
            services.AddTransient<CityForm, CityForm>();
            services.AddTransient<CustomerForm, CustomerForm>();
            services.AddTransient<ProductForm, ProductForm>();
            services.AddTransient<SaleForm, SaleForm>();
            services.AddTransient<UserForm, UserForm>();
            services.AddTransient<HelpForm, HelpForm>();

            services.AddSingleton(
                new MapperConfiguration(config => {
                    config.CreateMap<Categoria, CategoryModel>();
                    config.CreateMap<Funcionario, UserModel>();
                    config.CreateMap<Carro, ProductModel>()
                        .ForMember(d => d.Category, d => d.MapFrom(x => x.Category!.Name))
                        .ForMember(d => d.IdCategory, d => d.MapFrom(x => x.CategoryId));
                    config.CreateMap<Cliente, CustomerModel>()
                        .ForMember(d => d.Name, d => d.MapFrom(x => x.Nome))
                        .ForMember(d => d.Document, d => d.MapFrom(x => x.DocumentId))
                        .ForMember(d => d.City, d => d.MapFrom(x => x.City!.Name))
                        .ForMember(d => d.IdCity, d => d.MapFrom(x => x.CityId));
                    config.CreateMap<Cidade, CityModel>();
                    config.CreateMap<Locacao, SaleModel>()
                        .ForMember(d => d.User, d => d.MapFrom(x => x.Salesman.Name)) // Mapeia nome do vendedor
                        .ForMember(d => d.IdUser, d => d.MapFrom(x => x.Salesman!.Id))
                        .ForMember(d => d.Customer, d => d.MapFrom(x => x.Customer.Nome)) // Mapeia nome do cliente
                        .ForMember(d => d.IdCustomer, d => d.MapFrom(x => x.Customer!.Id))
                        .ForMember(d => d.Quantity, d => d.MapFrom(x => x.SaleItens.Sum(s => s.Quantity)));

                    config.CreateMap<Funcionario, Funcionario>();        
                    config.CreateMap<Categoria, Categoria>(); 
                    config.CreateMap<Carro, Carro>();   
                    config.CreateMap<Cliente, Cliente>(); 
                    config.CreateMap<Cidade, Cidade>();         
                    config.CreateMap<Locacao, Locacao>();         
                    config.CreateMap<SaleItem, SaleItem>();
                },
                NullLoggerFactory.Instance).CreateMapper());
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
