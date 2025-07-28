using Service.DTO;
using TheKirana.Model.Models;
namespace AutoMapper.Mapper
{
    public class ModelMapper : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelMapper"/> class, configuring mappings between DTOs and
        /// domain models.
        /// </summary>
        /// <remarks>This constructor sets up bidirectional mappings between data transfer objects (DTOs)
        /// and their corresponding domain models. The mappings are configured using AutoMapper, allowing for seamless
        /// conversion between DTOs and entities in both directions.</remarks>
        #region Conructor
        public ModelMapper()
        {
            CreateMap<UserDto, ApplicationUser>().ReverseMap();
            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<PaymentDto, Payment>().ReverseMap();
            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CartDto, CartItem>().ReverseMap();
            CreateMap<AddressDto, Address>().ReverseMap();
        }
        #endregion
    }
}
