using Cirrious.CrossCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Test.Core.Model;
using Test.Core.ViewModel;

namespace Test.Core.Service
{
    public class SpaceService : ISpaceService
    {
        private Dictionary<int, SpaceView> _spaceViews = new Dictionary<int, SpaceView>();

        public SpaceService()
        {
            InitializeSpaceViews();
        }

        public SpaceView GetSpaceViewById(int id)
        {
            return _spaceViews[id];
        }

        private void InitializeSpaceViews()
        {
            _spaceViews = new Dictionary<int, SpaceView>
            {

                {
                    1,
                    new SpaceView
                    {
                         SpaceItem = new SpaceForm("Test1", Mvx.IocConstruct<SpaceForm1ViewModel>())
                         {
                             SpaceFileds = new ObservableCollection<SpaceField<object>>
                             {
                                 new SpaceField<object> { InputType = InputType.TextBox, Label = "Label1", FieldValue = "Field1" },
                                 new SpaceField<object> { InputType = InputType.TextBox, Label = "Label2", FieldValue = "Field2"  },
                                 new SpaceField<object> { InputType = InputType.TextBox, Label = "Label3", FieldValue = "Field3"  },
                                 new SpaceField<object> { InputType = InputType.TextBox, Label = "Label4", FieldValue = "Field4"  },
                                 new SpaceField<object> { InputType = InputType.TextBox, Label = "Label5" ,FieldValue = "Field5" },
                             },
                         }
                    }
                },

                {
                    2,
                    new SpaceView
                    {
                         SpaceItem = new SpaceReadOnlyForm("Test1", Mvx.IocConstruct<SpaceReadOnlyFormViewModel>()),
                    }
                }
            };
        }
    }
}
