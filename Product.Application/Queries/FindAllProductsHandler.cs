using MediatR;
using Product.Application.Queries.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Product.Application.Queries
{
    public class FindAllProductsHandler : IRequestHandler<FindAllProductsQuery, IEnumerable<ProductDto>>
    {
        //private readonly IProductRepository productRepository;

        public FindAllProductsHandler(//IProductRepository productRepository
                                      )
        {
            //this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public async Task<IEnumerable<ProductDto>> Handle(FindAllProductsQuery request, CancellationToken cancellationToken)
        {
            var result = Enumerable.Repeat(new ProductDto() { }, 2);
            return result;
        }
    }
}
