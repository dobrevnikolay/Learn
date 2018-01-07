

using System;
using System.Diagnostics;
using System.Globalization;

namespace WindowBeginningEduGame
{

    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class MenuPageContextConverter : BaseValueConverter<MenuPageContextConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch((ControlContext)value)
            {
                case ControlContext.TopicMenu:
                    return new TopicMenuControl();
                case ControlContext.Reading:
                    return new ReadingControl();
                case ControlContext.Question:
                    return new QuestionControl();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
