using test.Domain.Common;
using System.Threading.Tasks;

namespace test.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
