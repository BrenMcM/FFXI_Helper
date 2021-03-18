using FFXI.MainUI.Enums;

namespace FFXI.MainUI.Entities
{
    public class PlayerItem 
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int ContainerIndex { get; set; }
        public ItemContainerType Container { get; set; }
    }
}
