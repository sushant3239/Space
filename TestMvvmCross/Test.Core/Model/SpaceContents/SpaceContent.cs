using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Test.Core.Model
{
    public abstract class SpaceContent
    {
        public SpaceContent(string header, MvxViewModel viewModel)
        {
            SpaceItemHeader = header;
            ViewModel = viewModel;
            OnViewModelSet();
        }

        public string SpaceItemHeader { get; protected set; }
        public MvxViewModel ViewModel { get; protected set; }
        public virtual ObservableCollection<SpaceField<object>> SpaceFileds { get; set; }
        protected virtual void OnViewModelSet() { }
    }
}
