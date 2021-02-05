using AutoFixture;
using AutoFixture.Xunit2;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotnetExploration
{
    internal class MapperAutoDataAttribute : AutoDataAttribute
    {
        public MapperAutoDataAttribute() : base(() =>
        {
            var fixture = new Fixture();

            var collection = new ServiceCollection();

            collection.AddAutoMapper(configAction =>
            {
                configAction.CreateMap<Model1Intrant, Model2Intrant>();

                configAction.CreateMap<Model2Intrant, Model3Intrant>()
                            .ForMember(m => m.X, o => o.MapFrom(sm => sm.A))
                            .ForMember(m => m.Y, o => o.MapFrom(sm => sm.B));

                configAction.CreateMap<Model3Extrant, Model2Extrant>()
                            .ForMember(m => m.Resultat, o => o.MapFrom(sm => sm.Restult));

                configAction.CreateMap<Model2Extrant, Model1Extrant>()
                            .ForMember(m => m.Result, o => o.MapFrom(sm => sm.Resultat));
            });

            collection.AddTransient<ICalculatriceService, CalcuraticeService>()
                      .AddTransient<CrazyCalculatrice>();

            var builder = collection.BuildServiceProvider();

            fixture.Register(() => builder.GetRequiredService<CrazyCalculatrice>());

            return fixture;
        })
        {

        }
    }
}