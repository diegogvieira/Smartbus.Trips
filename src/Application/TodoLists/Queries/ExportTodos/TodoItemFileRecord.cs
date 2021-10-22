using Smartbus.Trips.Application.Common.Mappings;
using Smartbus.Trips.Domain.Entities;

namespace Smartbus.Trips.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
