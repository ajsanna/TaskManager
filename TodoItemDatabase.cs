using SQLite;

namespace TaskManager
{
    public class TodoItemDatabase  // Changed from internal to public
    {
        SQLiteAsyncConnection? Database;

        public TodoItemDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DBPath, Constants.trigger);
            var result = await Database.CreateTableAsync<ToDoItem>();
        }

        //...

        public async Task<List<ToDoItem>> GetItemsAsync()
        {
            await Init();
            return await Database!.Table<ToDoItem>().ToListAsync();
        }

        public async Task<List<ToDoItem>> GetItemsNotDoneAsync()
        {
            await Init();
            return await Database!.Table<ToDoItem>().Where(t => t.Done).ToListAsync();
        }

        public async Task<ToDoItem> GetItemAsync(int id)
        {
            await Init();
            return await Database!.Table<ToDoItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public async Task<int> SaveItemAsync(ToDoItem item)
        {
            await Init();
            if (item.ID != 0)
                return await Database!.UpdateAsync(item);
            else
                return await Database!.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(ToDoItem item)
        {
            await Init();
            return await Database!.DeleteAsync(item);
        }

        /*
        public async Task DeleteAllTasksAsync()
        {
            await Init(); // Ensure the database is initialized
            await Database!.ExecuteAsync("DELETE FROM TodoItem");
        } */

    }
}




