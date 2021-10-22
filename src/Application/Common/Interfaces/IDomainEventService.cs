using Smartbus.Trips.Domain.Common;
using System.Threading.Tasks;

namespace Smartbus.Trips.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
