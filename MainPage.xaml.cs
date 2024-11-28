using Microsoft.Maui.Controls;


namespace TaskManager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Navigates to AddPage to add a task
        private void AddTaskBtn_Clicked(object sender, EventArgs e)
        {
            // Create the TodoItemDatabase instance
            TodoItemDatabase database = new TodoItemDatabase();

            // Pass the database instance to AddPage constructor
            Navigation.PushAsync(new AddPage(database));
        }


        // Navigates to ViewPage to view tasks
        private void ViewTasksBtn_Clicked(object sender, EventArgs e)
        {
            // Create the TodoItemDatabase instance
            TodoItemDatabase database = new TodoItemDatabase();

            // Pass the database instance to ViewPage constructor
            Navigation.PushAsync(new ViewPage(database));
        }
    }
}

