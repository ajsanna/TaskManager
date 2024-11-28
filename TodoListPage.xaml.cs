using Microsoft.Maui.Controls;

namespace TaskManager
{
    public partial class TodoListPage : ContentPage
    {
        private readonly TodoItemDatabase _database;

        // Constructor
        public TodoListPage(TodoItemDatabase database)
        {
            InitializeComponent();
            _database = database;

            // Load the tasks when the page is loaded
            LoadTasks();
        }

        // Method to load tasks from the database and display them
        private async void LoadTasks()
        {
            var tasks = await _database.GetItemsAsync();
            // Assuming you have a ListView or CollectionView named "TasksListView"
            TasksListView.ItemsSource = tasks;
        }

        // Navigate to AddPage to add a new task
        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage(_database));
        }
    }
}

