using System.Windows;
using System.Windows.Controls;

namespace TemplateCCNew8.LessonOne
{
    public class LessonOne : Control
    {
        static LessonOne()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof( LessonOne ),
                new FrameworkPropertyMetadata( typeof( LessonOne ) ) );
        }
    }
}
