using API.DTO.Goodss;
using API.Services.Goodss;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Goods
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : Controller
    {
        private readonly IGoodsService _goodsService;
        public GoodsController(IGoodsService goodsService)

        {
            _goodsService = goodsService;
        }

        [HttpPost("CreateGoods")]
        public IActionResult CreateGoods(GoodsDto group)
        {
            var result = _goodsService.Create(group);
            return Ok(result);
        }

    }
}
