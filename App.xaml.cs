namespace Online_Exam_System_Application_2
{
    public partial class MauiApp2 : Application
    {
        public MauiApp2()
        {
            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}