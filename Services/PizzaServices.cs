
using ModelsPizza.Models;
namespace PizzaServices.Services;

//Servicio para simular el crud en memoria 
public static class PizzaService
{
    static List<Pizza> pizzas { get; set; }
    static int nextId = 3;

    //Constructor
    static PizzaService()
    {
        //Inicializacion de la lista
        pizzas = [];
        //Creacion de los objetos pizza para luego introducirlos en la lista en memoria
        Pizza pizza1 = new(1, "Pizza con piña", true);
        Pizza pizza2 = new(2, "Pizza trifazica", false);
        pizzas.Add(pizza1);
        pizzas.Add(pizza2);
    }

    //Obtener todos los datos de la lista
    public static List<Pizza> GetAll() => pizzas;


    //Obtener pizza por id
    public static Pizza? GetById(int id) => pizzas.FirstOrDefault(p => p.Id == id);

    //Agregar elemento a la lista
    public static void Add(Pizza pizza)
    {
        //Le asigno el vallor del id 
        pizza.Id = nextId++;
        //Agrego la pizza a la lista
        pizzas.Add(pizza);
    }

    //Eliminar una pizza de la lista
    public static void Delete(int id)
    {
        //invoco al metodo GetById, pero primero creo una variable para almacenar esa respuesta y despues vallidar
        var pizzaFound = GetById(id);
        //valido
        if (pizzaFound is null)
        { 
            Console.WriteLine($"Pizza with id{id} not found");
        }
        else
        {
            pizzas.Remove(pizzaFound);
        }
    }

    //Actualizar una pizza

    public static void Update(Pizza pizza){
        
        var index = pizzas.FindIndex(p=>p.Id==pizza.Id);
        //index arroja 0 o -1
        if (index==-1)
        {
            return ;
        }else{
            //la piza en la posicion index = pizza
            pizzas[index]=pizza;
        }

    }

}