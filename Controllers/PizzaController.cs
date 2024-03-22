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
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    //Consultar por id

}