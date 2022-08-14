using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;
        public BasketController(IBasketRepository basketRepository, IMapper mapper)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketByid(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);
            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerbasket=_mapper.Map<CustomerBasketDto,CustomerBasket>(basket);
            var updatedbasket = await _basketRepository.UpdateBasketAsync(customerbasket);
            return Ok(updatedbasket);
        }

        [HttpDelete]
        public async Task DeleteBasketAsync(string Id)
        {
            await _basketRepository.DeleteBasketAsync(Id);

        }

    }
}