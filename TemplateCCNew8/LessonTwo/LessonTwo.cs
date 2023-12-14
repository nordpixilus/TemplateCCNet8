using System.Windows;
using System.Windows.Controls;

namespace TemplateCCNew8.LessonTwo;

public class LessonTwo : Control
{
    static LessonTwo()
    {
        DefaultStyleKeyProperty.OverrideMetadata(
            typeof( LessonTwo ),
            new FrameworkPropertyMetadata( typeof( LessonTwo ) ) );
    }
}
