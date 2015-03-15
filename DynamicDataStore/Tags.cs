using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Data;
using EPiServer.Data.Dynamic;

namespace EPiServer.Templates.Alloy.Models.DynamicDataStore
{
    [EPiServerDataStore(AutomaticallyCreateStore = true, AutomaticallyRemapStore = true)]
    public class Tags : IDynamicData
    {
        public Identity Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public string ItemType { get; set; }

        public Tags()
        {
            Initilizer();
        }

        public Tags(string name, int itemId, string itemType)
        {
            name = Name;
            itemId = ItemId;
            itemType = ItemType;
        }

        public void Initilizer()
        {
            Id = Identity.NewIdentity(Guid.NewGuid());

        }

    }
}