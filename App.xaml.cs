namespace TaskManager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window(new AppShell());

            // Adjust the window size and position (Windows/macOS)
#if WINDOWS || MACCATALYST
            var screenWidth = DeviceDisplay.MainDisplayInfo.Width;
            var screenHeight = DeviceDisplay.MainDisplayInfo.Height;
            var windowWidth = 600;
            var windowHeight = 800;

            // Calculate the position to center the window on the screen
            var windowX = (screenWidth / 2) - (windowWidth / 2);
            var windowY = (screenHeight / 2) - (windowHeight / 2);

            window.Width = windowWidth;
            window.Height = windowHeight;
            window.X = windowX;
            window.Y = windowY;

            window.MinimumWidth = windowWidth;
            window.MinimumHeight = windowHeight;
#endif

            return window;
        }
    }
}
