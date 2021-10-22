using Smartbus.Trips.Domain.Common;
using Smartbus.Trips.Domain.ValueObjects;
using System.Collections.Generic;

namespace Smartbus.Trips.Domain.Entities
{
    public class TodoList : AuditableEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
