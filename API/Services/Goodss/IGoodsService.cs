using API.Data.Entity;
using API.DTO.Goodss;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Goodss
{
    public interface IGoodsService
    {
        public Task<ActionResult<Goods>> Create(GoodsDto group);
    }
}
