using Syncfusion.Maui.Toolkit.Charts;

namespace Online_Exam_System_Application_2.Pages.Controls
{
    public class LegendExt : ChartLegend
    {
        protected override double GetMaximumSizeCoefficient()
        {
            return 0.5;
        }
    }
}
