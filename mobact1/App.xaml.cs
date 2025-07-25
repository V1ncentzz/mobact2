namespace mobact1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }


            protected override Window CreateWindow(IActivationState? activationState)
            {
            // loads MainPage as the root page.
            return new Window(new NavigationPage(new MainPage()));
            }
    }
}