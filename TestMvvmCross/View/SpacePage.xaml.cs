using Cirrious.CrossCore;
using Test.Core;
using Test.Core.Model.VirtualViews;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TestMvvmCross.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpacePage : Page
    {
        public SpacePage()
        {
            this.InitializeComponent();
            DataContext = Mvx.IocConstruct<EmployeeView>();            
        }
    }
}
