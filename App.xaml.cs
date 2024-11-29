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
            var screenWidth = DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;
            var screenHeight = DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;
            var windowWidth = 600;
            var windowHeight = 800;

            // Calculate the position to center the window on the screen
            var windowX = (screenWidth / 2) - (windowWidth / 2);
            var windowY = (screenHeight / 2) - (windowHeight / 2);

            window.Width = windowWidth;
            window.Height = windowHeight;
            window.X = windowX;
            window.Y = windowY;

            // Buttons and tasks squish to unusable below 300
            window.MinimumWidth = 300;
            window.MinimumHeight = 300;
#endif

            return window;
        }
    }
}
