using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Data;
using EPiServer.Data.Dynamic;
using EPiServer.DynamicContent;

namespace EPiServer.Templates.Alloy.Models.DynamicDataStore
{
    [EPiServerDataStore(AutomaticallyCreateStore = true, AutomaticallyRemapStore = true)]
    public class CategoriesPosts : IDynamicData
    {
        public Identity Id { get; set; }
        public Identity PostId { get; set; }
        
    }
}