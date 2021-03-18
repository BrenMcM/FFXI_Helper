using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXI.MainUI.Interfaces
{
    public interface IListItem
    {
        int Value { get; }
        string Label { get; }
    }
}
