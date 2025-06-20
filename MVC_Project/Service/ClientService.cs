using MVC_Project.Models.Client;
using MVC_Project.Models.Repository;

namespace MVC_Project.Service;

public class ClientService
{
    private readonly IClientRepository _repository;

    public ClientService(IClientRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<Client> GetAll() => _repository.GetAll();
    public Client? GetById(int id) => _repository.GetById(id);
    public IEnumerable<Client> GeyByName(string name) => _repository.GetByName(name);
    public Client Create(Client client) => _repository.Create(client);
    public Client? Update(int id, Client client) => _repository.Update(id, client);
    public bool Delete(int id) => _repository.Delete(id);
}