namespace SirenSharp.Examples
{
    using System.Collections.Generic;

    using SirenSharp.Mvc;

    public class Order : SirenEntity
    {
        public Order()
        {
            this.AddClass("order");

            this.Properties.OrderId = 123;
            this.Properties.OrderNumber = 384573;
            this.Properties.ItemCount = 4;
            this.Properties.Status = "Active";
            this.Properties.CustomerId = 2;

            this.AddLink(new SirenLink(HyperMediaHelper.GenerateAbsoluteUrl("orders/" + (this.Properties.OrderId - 1)), "previous"));
            this.AddLink(new SirenLink(HyperMediaHelper.GenerateAbsoluteUrl("orders/" + this.Properties.OrderId), "self"));
            this.AddLink(new SirenLink(HyperMediaHelper.GenerateAbsoluteUrl("orders/" + (this.Properties.OrderId + 1)), "next"));

            this.AddAction(new SirenAction("add-item", HyperMediaHelper.GenerateAbsoluteUrl("orders/" + this.Properties.OrderId + "/items"))
            {
                Title = "Add Item",
                Method = HttpVerbs.Post,
                Type = "application/x-www-form-urlencoded",
                Fields = new List<SirenField>()
                    {
                        new SirenField("orderNumber") { Type = FieldTypes.Hidden, Value = this.Properties.OrderId },
                        new SirenField("productCode") { Type = FieldTypes.Text },
                        new SirenField("quantity") { Type = FieldTypes.Number }
                    }
            });
        }
    }
}
