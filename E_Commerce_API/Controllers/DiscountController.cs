using E_Commerce_Business.Repository.IRepository;
using E_Commerce_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountRepository _discountRepository;
        public DiscountController(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }


        [HttpPost]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> CreateCampaign(DiscountDTO discount)
        {
            var result = await _discountRepository.CampaignCode(discount);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }




        [HttpGet("{couponCode}")]
        public async Task<ActionResult<ServiceResponse<DiscountDTO>>> Implemented([FromRoute]string couponCode)
        {
            var result = await _discountRepository.ImplementCode(couponCode);
            return Ok(result);
        }



    }
}
