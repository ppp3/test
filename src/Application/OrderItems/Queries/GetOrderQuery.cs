using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using test.Application.Common.Interfaces;
using test.Application.Common.Security;
using test.Domain.Enums;
using test.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using test.Application.Common.Models;
using System.Threading;

namespace test.Application.Order.Queries
{

    //public class GetTodoItemsWithPaginationQuery : IRequest<PaginatedList<TodoItemDto>>
    public class GetOrderQuery : IRequest<test.Domain.Entities.Order>
    {
        // Query
        public int Id { get; set; }
    }

    //public class GetTodoItemsWithPaginationQueryHandler : IRequestHandler<GetTodoItemsWithPaginationQuery, PaginatedList<TodoItemDto>>
    public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, test.Domain.Entities.Order>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<test.Domain.Entities.Order> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {

            test.Domain.Entities.Order order =  await _context.OrderItems.FindAsync(request.Id);
            return order;
            
        }
    }

    

    public record GetOrderQueryResponse : Response
            {
                public int Id { get; init; }
                public string Name { get; init; }
                public bool Completed { get; init; }
                public Customer Customer { get; init; }

                public int CustomerId { get; init; }

                public DateTime Date { get; init; }

                public IList<OrderPosition> OrderPosition { get; init; } = new List<OrderPosition>();
            }
    

    


}
