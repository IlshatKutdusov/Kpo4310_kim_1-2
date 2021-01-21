using System.Collections.Generic;

namespace Kpo4310.kim.Lib
{
    public interface IAccessoryListLoader
    {
        List<Accessory> accessoryList { get; }
        AccessoryListSplitFileLoader.LoadStatus status { get; }

        void Execute();
    }
}