using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Data;
using EPiServer.Data.Dynamic;

namespace EPiServer.Templates.Alloy.Models.DynamicDataStore
{
    [EPiServerDataStore(AutomaticallyCreateStore = true, AutomaticallyRemapStore = true)]
    public class Categories : IDynamicData
    {
        public Identity Id { get; set; }
        public string Name { get; set; }
        public virtual CategoriesPosts CategoriesPosts { get; set; }

        public Categories()
        {
            Initilizer();
        }

        public Categories(string name)
        {
            name = Name;
        }

        private void Initilizer()
        {
            Id = Identity.NewIdentity(Guid.NewGuid());

            Name = string.Empty;
        }

    }
}