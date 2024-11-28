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

            // You could use a ListView or CollectionView here to display the tasks
            TasksListView.ItemsSource = tasks;
        }
    }
}
