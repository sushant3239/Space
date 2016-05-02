using System.Collections.Generic;

namespace Test.Core.Model
{
    public class SplitView
    {
        public List<SplitViewItem> Items { get; set; }
    }

    public class SplitViewItem
    {
        public string Title { get; set; }

        public SpaceForm Content { get; set; }
    }
}
