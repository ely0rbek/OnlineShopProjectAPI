using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Application.IServices;
using Project.Application.Services;
using Project.Domain.Entities.PersonModelDTO;
using Project.Domain.Entities.PersonModels;
using Project.Infrastructure.Repositories;

namespace ProjectCRUD.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly ICostumerService _customerService;
        public CostumerController()
        {
            _customerService = new CustomerService();
        }
        [HttpGet]
        public async Task<IActionResult> GetByID(long id)
        {
            return Ok(_customerService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> PostData(Customer customer)
        {
            return Ok(_customerService.PostData(customer));
        }

        [HttpPatch]
        public async Task<IActionResult> updateCustomer(long id,CustomerDTO customer)
        {
            return Ok(_customerService.updateCustomer(id,customer));
        }


        [HttpDelete]
        public async Task<IActionResult> deleteCustomer(long id)
        {
            return Ok(_customerService.deleteCustomer(id));
        }

    }
}
