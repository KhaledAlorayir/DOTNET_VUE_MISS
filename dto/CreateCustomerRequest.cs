using System.ComponentModel.DataAnnotations;

public class CreateCustomerRequest {
    [Required]
    [StringLength(50)]
    public string firstname {get; set;}
    [Required]
    [StringLength(50)]
    public string lastname {get; set;}
}