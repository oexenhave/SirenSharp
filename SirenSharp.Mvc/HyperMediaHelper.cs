namespace SirenSharp.Mvc
{
    using System.Web;

    public class HyperMediaHelper
    {
        public static string GenerateAbsoluteUrl(string relativeUrl)
        {
            if (HttpRuntime.AppDomainAppVirtualPath != null)
            {
                return string.Format("{0}://{1}{2}/{3}", HttpContext.Current.Request.Url.Scheme, HttpContext.Current.Request.Url.Authority, HttpRuntime.AppDomainAppVirtualPath.TrimEnd('/'), relativeUrl.TrimStart('/'));
            }

            return relativeUrl;
        }

        public static string GenerateAbsoluteUrl(string relativeUrl, params object[] args)
        {
            if (HttpRuntime.AppDomainAppVirtualPath != null)
            {
                var url = string.Format(relativeUrl, args);
                return string.Format("{0}://{1}{2}/{3}", HttpContext.Current.Request.Url.Scheme, HttpContext.Current.Request.Url.Authority, HttpRuntime.AppDomainAppVirtualPath.TrimEnd('/'), url.TrimStart('/'));
            }

            return relativeUrl;
        }
    }
}
