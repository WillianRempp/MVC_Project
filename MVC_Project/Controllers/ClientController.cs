using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models.Client;
using MVC_Project.Service;

namespace MVC_Project.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController(ClientService service) : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Client>> GetAll() => Ok(service.GetAll());

    [HttpGet("{id:int}")]
    public ActionResult<Client> GetById(int id)
    {
        var cliente = service.GetById(id);
        return cliente == null ? NotFound() : Ok(cliente);
    }

    [HttpGet("name/{name}")]
    public ActionResult<IEnumerable<Client>> GetByName(string name) => Ok(service.GeyByName(name));

    [HttpPost]
    public ActionResult<Client> Create([FromBody] Client client)
    {
        var created = service.Create(client);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] Client client)
    {
        var updated = service.Update(id, client);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        return service.Delete(id) ? NoContent() : NotFound();
    }
}