namespace TaskManager
{
    public partial class ViewPage : ContentPage
    {
        private readonly TodoItemDatabase _database;

        public ViewPage(TodoItemDatabase database)
        {
            InitializeComponent();
            _database = database;

            // Load tasks when the page is created
            LoadTasks();
            
            //ClearDatabase();
        }

        // Method to load tasks from the database
        private async void LoadTasks()
        {
            var tasks = await _database.GetItemsAsync(); // Fetch tasks from database
            TasksListView.ItemsSource = tasks; // Bind tasks to ListView
        }

        // Event handler for when a task is tapped
        private async void OnTaskTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is ToDoItem tappedTask)
            {
                // Navigate to the TodoItemPage with the tapped task
                await Navigation.PushAsync(new TodoItemPage(tappedTask));
            }

            // Deselect the item in the ListView
            ((ListView)sender).SelectedItem = null;
        }

        // Must refresh tasks on load (In case of delete/add)
        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
            LoadTasks();
        }

        /*
        private async void ClearDatabase()
        {
            await _database.DeleteAllTasksAsync();
            Console.WriteLine("All tasks cleared.");
        }
        */
    }
}
