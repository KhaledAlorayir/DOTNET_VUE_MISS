public class GetCustomerResponse {
    public int id {get; set;}
    public string firstname {get; set;}
    public string lastname {get; set;}
    public ICollection<GetPetResponse> pets { get; set; } = new List<GetPetResponse>();

    public static GetCustomerResponse mapToGetCustomerResponse(Customer customer) {
        return new GetCustomerResponse(){
            firstname=customer.firstname,
            id=customer.id,
            lastname=customer.lastname,
            pets= customer.pets.Select(p => GetPetResponse.mapToGetPetResponse(p)).ToList()
        };
    }

}