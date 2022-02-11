using FFXI.Entourage_2.Enums;

namespace FFXI.Entourage_2.Entities
{
    public class PlayerItem 
    {
        public int ItemId { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public int ContainerIndex { get; set; }
        public ItemContainerType Container { get; set; }
    }
}
