using W12_Lab.ViewModel;

namespace W12_Lab
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            BindingContext = viewModel;
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            if (BindingContext is MainViewModel vm)
                vm.Add();
        }

        private void OnSubtractClicked(object sender, EventArgs e)
        {
            if (BindingContext is MainViewModel vm)
                vm.Subtract();
        }

        private void OnMultiplyClicked(object sender, EventArgs e)
        {
            if (BindingContext is MainViewModel vm)
                vm.Multiply();
        }

        private void OnDivideClicked(object sender, EventArgs e)
        {
            if (BindingContext is MainViewModel vm)
                vm.Divide();
        }
    }
}
