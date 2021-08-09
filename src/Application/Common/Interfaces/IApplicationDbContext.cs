using test.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace test.Application.Common.Interfaces
{

    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }

        DbSet<test.Domain.Entities.Order> OrderItems { get; set; }

        DbSet<Customer> CustomerItems { get; set; }

        DbSet<OrderPosition> OrderPositionItems { get; set; }

        DbSet<Book> BookItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}