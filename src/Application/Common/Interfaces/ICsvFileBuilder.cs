using Smartbus.Trips.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Smartbus.Trips.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
