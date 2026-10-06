using MongoDB.Driver;
using DockerStudies.API.Entities;

namespace DockerStudies.API.Data
{
    public interface IProductContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
