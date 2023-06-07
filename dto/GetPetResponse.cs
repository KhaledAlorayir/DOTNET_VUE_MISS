public class GetPetResponse {
    public int id { get; set; }
    public string name { get; set; }
    public string type { get; set; }

    public static GetPetResponse mapToGetPetResponse(Pet pet) {
        return new GetPetResponse(){id=pet.id, name=pet.name, type=pet.petType.type};
    }
}