//Api
using Microsoft.AspNetCore.Mvc;
using ModelsPizza.Models;
using PizzaServices.Services;

namespace ControllersControllerr.Controllers;

//Api controller para decirle que va hacer un controlador tipo API
[ApiController]
//route define la asignacion del token controller
[Route("[controller]")]
//ControllerBase es para trabajar con solicitudes http
public class PizzaController : ControllerBase
{

    //Constructor
    public PizzaController()
    {

    }
    //Obtener todos las pizzas get
    [HttpGet("GetAllPizzas")]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    //Consultar por id
    [HttpGet("{id}")]
    public ActionResult<Pizza> GetById(int id)
    {
        //Inyecto el servicio
        var pizza = PizzaService.GetById(id);
        if (pizza is null)
        {
            return NotFound();
        }
        else
        {
            return pizza;
        }
    }

    //Agregar una pizza a la lista
    [HttpPost]
    public AcceptedResult Create(Pizza pizza)
    {

        PizzaService.Add(pizza);
        return Accepted(pizza);
    }
    //Eliminar una pizza
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        
        if (id == 0)
        {
            return NotFound();
        }
        PizzaService.Delete(id);
        return Accepted();
    }
}