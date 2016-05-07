using Cirrious.MvvmCross.ViewModels;

namespace Test.Core.Model
{
    public class ViewField<T> : MvxNotifyPropertyChanged
    {
        private string _fieldLable;
        private T _fieldValue;

        public string FieldLable
        {
            get { return _fieldLable; }
            set
            {
                _fieldLable = value;
                RaisePropertyChanged();
            }
        }

        public T FieldValue
        {
            get { return _fieldValue; }
            set
            {
                _fieldValue = value;
                RaisePropertyChanged();
            }
        }

        public InputType InputType { get; set; }
    }
}
