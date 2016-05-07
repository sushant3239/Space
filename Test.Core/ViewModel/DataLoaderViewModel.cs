using Cirrious.MvvmCross.ViewModels;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Test.Core.ViewModel
{
    public class DataLoaderViewModel : MvxViewModel
    {
        private bool _loading;

        public bool Loading
        {
            get { return _loading; }
            set
            {
                _loading = value;
                RaisePropertyChanged();
            }
        }

        public async Task Load()
        {
            Loading = true;
            try
            {
                await LoadData();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            finally
            {
                Loading = false;
            }
        }

        protected async virtual Task LoadData() { }
       
    }
}
