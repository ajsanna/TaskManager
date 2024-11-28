namespace TaskManager;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
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
            DisplayAlert("Error", "Please fill in all fields.", "OK");
        }
        else
        {
            // Save the data (you can store it in a database, file, or model)
            Console.WriteLine($"Task Title: {taskTitle}");
            Console.WriteLine($"Description: {taskDescription}");
            Console.WriteLine($"Due Date: {taskDueDate}");

            Navigation.PopAsync();

            // Clear the entries after navigating back
            TaskEntry.Text = string.Empty;
            DescriptionEntry.Text = string.Empty;
            DateEntry.Text = string.Empty;
        }
    }

}