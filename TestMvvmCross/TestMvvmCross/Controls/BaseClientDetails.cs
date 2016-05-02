
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TestMvvmCross.Controls
{
    public class BaseClientDetails : UserControl
    {
        public string Test
        {
            get { return (string)GetValue(TestProperty); }
            set { SetValue(TestProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Test.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TestProperty =
            DependencyProperty.Register("Test", typeof(string), typeof(BaseClientDetails), null);


    }
}
