using Online_Exam_System_Application_2.Models;
using Online_Exam_System_Application_2.PageModels;

namespace Online_Exam_System_Application_2.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}