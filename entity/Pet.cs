public class Pet {
    public int id { get; set; }
    public string name { get; set; }
    public int petTypeId { get; set; }
    public PetType petType { get; set; } = null!;
    public int customerId { get; set; }
    public Customer customer { get; set; } = null!;
}