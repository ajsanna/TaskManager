using System.Formats.Tar;
using Microsoft.Maui.Controls;


namespace TaskManager
{
    public partial class AddPage : ContentPage
    {
        private readonly TodoItemDatabase _database;
        private TodoItem _task;

        // Constructor for adding a new task
        public AddPage(TodoItemDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        // Constructor for editing an existing task
        public AddPage(TodoItemDatabase database, TodoItem task)
        {
            InitializeComponent();
            _database = database;
            _task = task;
            TaskEntry.Text = _task.Name;
            DescriptionEntry.Text = _task.Description;
            DateEntry.Text = _task.DueDate;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string taskTitle = TaskEntry.Text;
            string taskDescription = DescriptionEntry.Text;
            string taskDueDate = DateEntry.Text;

            // Checking if all fields are filled
            if (string.IsNullOrWhiteSpace(taskTitle) ||
                string.IsNullOrWhiteSpace(taskDescription) ||
                string.IsNullOrWhiteSpace(taskDueDate))
            {
                // Error Message
                await DisplayAlert("Error", "Please fill in all fields.", "OK");
                return;
            }

            // If it's an existing task, update it
            if (_task != null)
            {
                _task.Name = taskTitle;
                _task.Description = taskDescription;
                _task.DueDate = taskDueDate;
                await _database.SaveItemAsync(_task);
            }
            else // Otherwise, create a new task
            {
                TodoItem newTask = new TodoItem
                {
                    Name = taskTitle,
                    Description = taskDescription,
                    DueDate = taskDueDate,
                    Done = false // Default value for new tasks (not done yet)
                };
                await _database.SaveItemAsync(newTask);
            }

            // Navigate back after saving
            await Navigation.PopAsync();

            // Clear the entries after navigating back
            TaskEntry.Text = string.Empty;
            DescriptionEntry.Text = string.Empty;
            DateEntry.Text = string.Empty;
        }
    }
}

