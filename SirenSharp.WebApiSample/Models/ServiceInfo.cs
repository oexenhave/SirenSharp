using SirenSharp.Mvc;

namespace SirenSharp.WebApiSample.Models
{
    public class ServiceInfo : SirenEntity
    {
        public ServiceInfo()
        {
            this.AddClass("serviceinfo");
            this.AddLink(new SirenLink(HyperMediaHelper.GenerateAbsoluteUrl("api"), "self"));
        }
    }
}