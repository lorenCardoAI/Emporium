using MediatR;
using Product.Application.Queries.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Application.Queries
{
    public class FindAllProductsQuery : IRequest<IEnumerable<ProductDto>>
    {

    }
}
