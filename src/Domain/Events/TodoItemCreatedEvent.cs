using Smartbus.Trips.Domain.Common;
using Smartbus.Trips.Domain.Entities;

namespace Smartbus.Trips.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
