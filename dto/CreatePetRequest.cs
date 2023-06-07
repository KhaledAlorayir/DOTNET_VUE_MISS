using System.ComponentModel.DataAnnotations;

public class CreatePetRequest {
    [Required]
    [StringLength(50)]
    public string name { get; set; }
    [Required]
    public int petTypeId { get; set; }
    [Required]
    public int customerId { get; set; }
}