using Smartbus.Trips.Application.Common.Exceptions;
using Smartbus.Trips.Application.TodoItems.Commands.CreateTodoItem;
using Smartbus.Trips.Application.TodoItems.Commands.DeleteTodoItem;
using Smartbus.Trips.Application.TodoLists.Commands.CreateTodoList;
using Smartbus.Trips.Domain.Entities;
using FluentAssertions;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Smartbus.Trips.Application.IntegrationTests.TodoItems.Commands
{
    using static Testing;

    public class DeleteTodoItemTests : TestBase
    {
        [Test]
        public void ShouldRequireValidTodoItemId()
        {
            var command = new DeleteTodoItemCommand { Id = 99 };

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<NotFoundException>();
        }

        [Test]
        public async Task ShouldDeleteTodoItem()
        {
            var listId = await SendAsync(new CreateTodoListCommand
            {
                Title = "New List"
            });

            var itemId = await SendAsync(new CreateTodoItemCommand
            {
                ListId = listId,
                Title = "New Item"
            });

            await SendAsync(new DeleteTodoItemCommand
            {
                Id = itemId
            });

            var item = await FindAsync<TodoItem>(itemId);

            item.Should().BeNull();
        }
    }
}
