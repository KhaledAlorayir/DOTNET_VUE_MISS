public class PetType {
    public int id { get; set; }
    public string type { get; set; }
    public ICollection<Pet> pets { get; } = new List<Pet>();
}