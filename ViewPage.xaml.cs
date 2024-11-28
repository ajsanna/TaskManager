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
        }

        // Method to load tasks from the database
        private async void LoadTasks()
        {
            var tasks = await _database.GetItemsAsync(); // Fetch tasks from database
            TasksListView.ItemsSource = tasks; // Bind tasks to ListView
        }

        // Event handler for when a task frame is clicked
        private async void OnTaskTapped(object sender, ItemTappedEventArgs e)
        {
            // Navigate to the TodoItemPage when a task is tapped, without passing any data
            await Navigation.PushAsync(new TodoItemPage());
        }

    }
}
