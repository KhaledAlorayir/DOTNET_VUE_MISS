
public class Customer {
    public int id {get; set;}
    public string firstname {get; set;}
    public string lastname {get; set;}
    public ICollection<Pet> pets { get; } = new List<Pet>();

}