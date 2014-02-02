﻿namespace SirenSharp.Examples
{
    using System;
    using System.Collections.Generic;

    public class Order : IHypermediaEntity
    {
        public int OrderId { get; set; }

        public int OrderNumber { get; set; }

        public int ItemCount { get; set; }

        public string Status { get; set; }

        public int CustomerId { get; set; }

        public IEnumerable<string> GetSirenClasses()
        {
            return new List<string>() { "order" };
        }

        public IEnumerable<SubEntity> GetSirenSubEntities()
        {
            return null;
        }

        public IEnumerable<Link> GetSirenLinks()
        {
            return new List<Link>()
            {
                new Link(new Uri("http://api.x.io/orders/" + (OrderId - 1)), "previous"),
                new Link(new Uri("http://api.x.io/orders/" + OrderId), "self"),
                new Link(new Uri("http://api.x.io/orders/" + (OrderId + 1)), "next")
            };
        }

        public IEnumerable<Action> GetSirenActions()
        {
            return new List<Action>()
            {
                new Action("add-item", new Uri("http://api.x.io/orders/" + OrderId + "/items"))
                {
                    Title = "Add Item",
                    Method = HttpVerbs.Post,
                    Type = "application/x-www-form-urlencoded",
                    Fields = new List<Field>()
                    {
                        new Field("orderNumber") { Type = FieldTypes.Hidden, Value = OrderId },
                        new Field("productCode") { Type = FieldTypes.Text },
                        new Field("quantity") { Type = FieldTypes.Number }
                    }
                }
            };
        }
    }
}