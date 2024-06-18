using EtecVeiculos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace EtecVeiculos.Api.Data;

public class AppDbSeed
{
    public AppDbSeed(ModelBuilder modelBuilder)
    {
        #region TipoVeiculo
        List<TipoVeiculo> tipoVeiculos = [
            new() {
                Id = 1,
                Name = "Moto"
            },
            new() {
                Id = 2,
                Name = "Carro"
            },
            new() {
                Id = 3,
                Name = "Caminhão"
            }
        ];
        modelBuilder.Entity<TipoVeiculo>().HasData(tipoVeiculos);
        #endregion

        #region Marcas
        List<Marca> marcas = new() {
            new() {
                Id = 1,
                Name = "Porsche",
            },
            new() {
                Id = 2,
                Name = "Ferrari",
            },
            new() {
                Id = 3,
                Name = "Bugatti",
            }
        };
        modelBuilder.Entity<Marca>().HasData(marcas);
        #endregion

        #region Modelo
        List<Modelo> modelos = new() {
            new() {
                Id = 1,
                Name = "Porsche 911 GT3 RS",
                MarcaId = 1,
            },
            new() {
                Id = 2,
                Name = "Ferrari 296 GTB",
                MarcaId = 2,
            },
        };
        modelBuilder.Entity<Modelo>().HasData(modelos);
        #endregion
    }
}
