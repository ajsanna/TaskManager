namespace TaskManager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddTaskBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPage());
        }

        private void ViewTasksBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewPage());
        }
    }

}
