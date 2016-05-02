using System;
using Test.Core.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace TestMvvmCross.Converters
{
    public class InputTypeToDataTemplateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var inputType = (InputType)value;
            switch (inputType)
            {
                case InputType.TextBox:
                    return App.Current.Resources["TextBoxTemplate"] as DataTemplate;

                case InputType.MultiLineTextBox:
                    return App.Current.Resources["RichEditBoxTemplate"] as DataTemplate;

                case InputType.ReadOnly:
                    return App.Current.Resources["TextBlockTemplate"] as DataTemplate;

                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
