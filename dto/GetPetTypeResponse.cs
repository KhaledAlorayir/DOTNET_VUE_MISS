public class GetPetTypeResponse {
    public int id { get; set; }
    public string type { get; set; }

    public static GetPetTypeResponse mapToGetPetTypeResponse(PetType petType) {
        return new GetPetTypeResponse(){
            id=petType.id,
            type=petType.type
        };
    }
}