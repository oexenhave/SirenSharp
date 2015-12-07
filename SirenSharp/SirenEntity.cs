namespace SirenSharp
{
    using System.Collections.Generic;
    using System.Dynamic;

    public class SirenEntity : ISirenEntity
    {
        public IList<string> Class { get; private set; }

        public dynamic Properties { get; private set; }

        public IList<SubEntity> Entities { get; private set; }

        public IList<SirenLink> Links { get; private set; }

        public IList<SirenAction> Actions { get; private set; }

        public string Title => null;

        protected void InitializeProperties()
        {
            this.Properties = new ExpandoObject();
        }

        protected void AddClass(string @class)
        {
            if (this.Class == null)
            {
                this.Class = new List<string>();
            }

            this.Class.Add(@class);
        }

        protected void AddEntities(SubEntity entity)
        {
            if (this.Entities == null)
            {
                this.Entities = new List<SubEntity>();
            }

            this.Entities.Add(entity);
        }

        protected void AddLink(SirenLink link)
        {
            if (this.Links == null)
            {
                this.Links = new List<SirenLink>();
            }

            this.Links.Add(link);
        }

        protected void AddAction(SirenAction action)
        {
            if (this.Actions == null)
            {
                this.Actions = new List<SirenAction>();
            }

            this.Actions = new List<SirenAction>();
        }
    }
}