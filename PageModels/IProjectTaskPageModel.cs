using CommunityToolkit.Mvvm.Input;
using Online_Exam_System_Application_2.Models;

namespace Online_Exam_System_Application_2.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}