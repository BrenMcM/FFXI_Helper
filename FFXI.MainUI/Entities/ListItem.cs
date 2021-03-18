using FFXI.MainUI.Interfaces;

namespace FFXI.MainUI.Entities
{
    public sealed class ListItem : IListItem
    {
        public int Value { get; set; }
        public string Label { get; set; }
    }
}
