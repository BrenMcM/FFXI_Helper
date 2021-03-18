using FFXI.MainUI.Entities;
using FFXI.MainUI.Enums;
using FFXI.MainUI.Interfaces;
using System.Collections.Generic;
using static EliteMMO.API.EliteAPI;

namespace FFXI.MainUI.Controllers
{
    public static class InventoryController
    {
        public static List<PlayerItem> GetContainerItems(int containerId)
        {
            List<PlayerItem> items = new List<PlayerItem>();
            int containerCount = ApiController.GetContainerCount(containerId);

            for (int i = 1; i <= containerCount; i++)
            {
                var item = ApiController.GetContainerItem(containerId, i);

                var iItem = ApiController.GetItemInfo(item.Id);

                if (iItem != null)
                {

                    var pItem = new PlayerItem()
                    {
                        ItemId = item.Id,
                        Name = iItem.Name[0],
                        ContainerIndex = i,
                        Container = (ItemContainerType)containerId
                    };

                    items.Add(pItem);
                }
            }

            return items;
        }
    }
}
