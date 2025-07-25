namespace mobact1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Event handler for the button to navigate
        private void OnCounterClicked(object? sender, EventArgs e)
        {
            //Navigation pushasync to navigate to flyoutpage
            Navigation.PushAsync(new flyoutxaml());
        }
    }
}
