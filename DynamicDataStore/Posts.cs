using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Data.Dynamic;
using EPiServer.Editor.TinyMCE;
using EPiServer.Data;

namespace EPiServer.Templates.Alloy.Models.DynamicDataStore
{
    [EPiServerDataStore(AutomaticallyCreateStore = true, AutomaticallyRemapStore = true)]
    public class Posts : IDynamicData
    {
        public Identity Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PostedAt { get; set; }
        public virtual CategoriesPosts CategoriesPosts { get; set; }

        public Posts()
        {
            Initilize();
        }

        public Posts(string title, string text, DateTime postedAt)
        {
            title = Title;
            text = Text;
            postedAt = PostedAt;
            
        }

        private void Initilize()
        {
            Id = Identity.NewIdentity(Guid.NewGuid());
        }


    }
}