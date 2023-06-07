using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/customers")]
public class CustomerController: ControllerBase {
    private readonly dbContext db;

    public CustomerController(dbContext db) {
        this.db = db;
    }

    [HttpGet]
    public IEnumerable<GetCustomerResponse> findAll() {
        return db.Customers.Include
        (c => c.pets).ThenInclude
        (p => p.petType).Select((c) => GetCustomerResponse.mapToGetCustomerResponse(c));
    }

    [HttpPost]
    public async Task<ActionResult<Customer>> create(CreateCustomerRequest createCustomerRequest) {
        Customer customer = new Customer{
            firstname = createCustomerRequest.firstname,
            lastname = createCustomerRequest.lastname
        };
        var result = await db.Customers.AddAsync(customer);
        db.SaveChanges();
        return new ObjectResult(customer){
            StatusCode = StatusCodes.Status201Created
        };
    }

}