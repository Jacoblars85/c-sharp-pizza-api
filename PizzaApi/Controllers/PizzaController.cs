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

    // POST action

    // PUT action

    // DELETE action
}