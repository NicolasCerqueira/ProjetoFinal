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
            services.AddScoped<IBaseRepository<CarrosAlugados>, BaseRepository<CarrosAlugados>>();

            // Services
            services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            services.AddScoped<IBaseService<Funcionario>, BaseService<Funcionario>>();//se der bosta comente isso 03/12
            services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            services.AddScoped<IBaseService<Carro>, BaseService<Carro>>();
            services.AddScoped<IBaseService<Locacao>, BaseService<Locacao>>();
            services.AddScoped<IBaseService<CarrosAlugados>, BaseService<CarrosAlugados>>();

            //Formularios
            services.AddTransient<Login, Login>();
            services.AddTransient<CategoriaForm, CategoriaForm>();
            services.AddTransient<CidadeForm, CidadeForm>();
            services.AddTransient<ClienteForm, ClienteForm>();
            services.AddTransient<CarroForm, CarroForm>();
            services.AddTransient<LocacaoForm, LocacaoForm>();//so falta terminar esse
            services.AddTransient<FuncionarioForm, FuncionarioForm>();
            services.AddTransient<HelpForm, HelpForm>();

            services.AddSingleton(
                new MapperConfiguration(config => {
                    config.CreateMap<Categoria, CategoriaModel>();
                    config.CreateMap<Funcionario, FuncionarioModel>();
                    config.CreateMap<Carro, CarroModel>()
                        .ForMember(d => d.Categoria, d => d.MapFrom(x => x.Categoria!.Nome))// para aparecer o nome no cbo
                        .ForMember(d => d.CategoriaId, d => d.MapFrom(x => x.CategoriaId));
                    config.CreateMap<Cliente, ClienteModel>()
                        .ForMember(d => d.Nome, d => d.MapFrom(x => x.Nome))
                        .ForMember(d => d.Cidade, d => d.MapFrom(x => x.Cidade!.Nome))
                        .ForMember(d => d.CidadeId, d => d.MapFrom(x => x.CidadeId)); ;
                    config.CreateMap<Cidade, CidadeModel>();
                    config.CreateMap<Locacao, LocacaoModel>()
                        .ForMember(d => d.Funcionario, d => d.MapFrom(x => x.Funcionario!.Nome)) //se aparecer no datagridview domain entities e isso
                        .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome));    
                    config.CreateMap<CarrosAlugados, CarrosAlugadosModel>();

                    config.CreateMap<Funcionario, Funcionario>();        
                    config.CreateMap<Categoria, Categoria>(); 
                    config.CreateMap<Carro, Carro>();   
                    config.CreateMap<Cliente, Cliente>(); 
                    config.CreateMap<Cidade, Cidade>();         
                    config.CreateMap<Locacao, Locacao>();         
                    config.CreateMap<Locacao, Locacao>();
                    config.CreateMap<CarrosAlugados, CarrosAlugados>();
                },
                NullLoggerFactory.Instance).CreateMapper());
            serviceProvider = services.BuildServiceProvider();
        }
    }
}