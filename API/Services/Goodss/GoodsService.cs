using API.Data;
using API.Data.Entity;
using API.DTO.Goodss;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.Goodss
{
    public class GoodsService : IGoodsService
    {
        private readonly DataContext _dataContext;
        public GoodsService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ActionResult<Goods>> Create(GoodsDto group)
        {
            try
            {
                var result = new Goods()
                {
                    GoodsName = group.GroupName,
                    Note = group.Note
                };
                await _dataContext.AddAsync(result);
                await _dataContext.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
