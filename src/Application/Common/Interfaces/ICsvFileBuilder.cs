using test.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace test.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
