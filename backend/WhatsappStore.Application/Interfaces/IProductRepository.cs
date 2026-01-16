using System;

namespace WhatsappStore.Application.Interfaces
{
	public interface IProductRepository()
	{
		// Retorna todos os produtos
		Task<IEnumerable<Product>> GetAll();

		// Retorna um produto pelo ID
		Task<Product> GetById(int id);

        // Adiciona um novo produto
		Task<Product> Add(Product product);

       
    }
}
