using PizzaApi.Models;
using PizzaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace PizzaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    // GET all action
    [HttpGet]
public ActionResult<List<Pizza>> GetAll() =>
    PizzaServices.GetAll();

    // GET by Id action
    [HttpGet("{id}")]
public ActionResult<Pizza> Get(int id)
{
    var pizza = PizzaService.Get(id);

    if(pizza == null)
        return NotFound();

    return pizza;
}

    // POST action

    // PUT action

    // DELETE action
}