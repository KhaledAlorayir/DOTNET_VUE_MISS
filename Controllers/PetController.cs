using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/pets")]
public class PetController: ControllerBase {
    private readonly dbContext db;

    public PetController(dbContext db) {
        this.db = db;
    }

    [HttpPost]
    public ActionResult<GetPetResponse> create(CreatePetRequest createPetRequest) {

        if(!db.Customers.Any((c) => c.id == createPetRequest.customerId)) {
            return BadRequest("no customer");
        }

        Pet pet = new Pet(){
            customerId=createPetRequest.customerId,
            petTypeId=createPetRequest.petTypeId,
            name=createPetRequest.name
        };
        db.Pets.Add(pet);
        db.SaveChanges();
        db.Entry(pet).Reference((p) => p.petType).Load();
        return GetPetResponse.mapToGetPetResponse(pet);
    }

    [HttpGet("types")]
    public IEnumerable<GetPetTypeResponse> getPetTypes() {
        return db.PetTypes.ToList().Select((type) => GetPetTypeResponse.mapToGetPetTypeResponse(type));
    }

}