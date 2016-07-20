namespace SirenSharp
{
    using System.Collections.Generic;
    using System.Dynamic;

    public class SirenEntity : ISirenEntity
    {
        public SirenEntity()
        {
            this.Properties = new ExpandoObject();
        }

        public IList<string> Class { get; private set; }

        public dynamic Properties { get; set; }

        public IList<SirenSubEntity> Entities { get; private set; }

        public IList<SirenLink> Links { get; private set; }

        public IList<SirenAction> Actions { get; private set; }

        public string Title => null;

        public void AddClass(string @class)
        {
            if (this.Class == null)
            {
                this.Class = new List<string>();
            }

            this.Class.Add(@class);
        }

        public void AddEntities(SirenSubEntity entity)
        {
            if (this.Entities == null)
            {
                this.Entities = new List<SirenSubEntity>();
            }

            this.Entities.Add(entity);
        }

        public void AddLink(SirenLink link)
        {
            if (this.Links == null)
            {
                this.Links = new List<SirenLink>();
            }

            this.Links.Add(link);
        }

        public void AddAction(SirenAction action)
        {
            if (this.Actions == null)
            {
                this.Actions = new List<SirenAction>();
            }

            this.Actions.Add(action);
        }
    }
}