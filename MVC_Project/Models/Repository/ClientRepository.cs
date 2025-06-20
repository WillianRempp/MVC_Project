namespace MVC_Project.Models.Repository;

public class ClientRepository : IClientRepository
{
    private readonly List<Client.Client> _clients = [];
    private int _nextId = 1;

    public IEnumerable<Client.Client> GetAll() => _clients;

    public Client.Client? GetById(int id) => _clients.FirstOrDefault(c => c.Id == id);

    public IEnumerable<Client.Client> GetByName(string name) =>
        _clients.Where(c => c.Name.Contains(name, StringComparison.OrdinalIgnoreCase));

    public Client.Client Create(Client.Client client)
    {
        client.Id = _nextId++;
        _clients.Add(client);
        return client;
    }

    public Client.Client? Update(int id, Client.Client client)
    {
        var existing = GetById(id);
        if (existing == null) return null;
        existing.Name = client.Name;
        existing.Email = client.Email;
        return existing;
    }

    public bool Delete(int id)
    {
        var client = GetById(id);
        return client != null && _clients.Remove(client);
    }
}