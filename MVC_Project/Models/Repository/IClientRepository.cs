namespace MVC_Project.Models.Repository;

public interface IClientRepository
{
    IEnumerable<Client.Client> GetAll();
    Client.Client? GetById(int id);
    IEnumerable<Client.Client> GetByName(string name);
    Client.Client Create(Client.Client client);
    Client.Client? Update(int id, Client.Client client);
    bool Delete(int id);
    int Count();
}