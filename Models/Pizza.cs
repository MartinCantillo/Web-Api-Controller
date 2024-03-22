namespace ModelsPizza.Models;


public class Pizza
{
    //Atributos publicos
    public int Id { get; set; }
    public String? Name { get; set; }
    public bool IsGlutenFree { get; set; }

    public Pizza(int Id,String Name,bool IsGlutenFree ){
        this.Id=Id;
        this.Name=Name;
        this.IsGlutenFree=IsGlutenFree;
    }
}