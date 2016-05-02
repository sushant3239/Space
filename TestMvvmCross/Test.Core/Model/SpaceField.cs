using Cirrious.MvvmCross.ViewModels;

namespace Test.Core.Model
{
    public class SpaceField<T> : MvxNotifyPropertyChanged
    {
        private T _fieldValue;

        public string Label { get; set; }

        public InputType InputType { get; set; }

        public T FieldValue
        {
            get { return _fieldValue; }
            set
            {
                _fieldValue = value;
                RaisePropertyChanged();
            }
        }
    }
}
