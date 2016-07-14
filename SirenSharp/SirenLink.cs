using Newtonsoft.Json;

namespace SirenSharp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Links represent navigational transitions.
    /// </summary>
    public class SirenLink
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SirenLink"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference</param>
        /// <param name="rel">Unique relationship</param>
        public SirenLink(Uri href, params string[] rel)
        {
            this.Rel = rel;
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SirenLink"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference (e.g. SirenSharp.Mvc.HyperMediaHelper.GenerateAbsoluteUrl("Info"))</param>
        /// <param name="rel">Unique relationship (e.g. "parent", "self")</param>
        public SirenLink(string href, params string[] rel)
        {
            this.Rel = rel;
            this.Href = new Uri(href, UriKind.RelativeOrAbsolute);
        }

        /// <summary>
        /// Gets or sets the unique relationship. It defines the relationship of the link to its entity, per Web Linking
        /// (RFC5899). MUST be an array of strings. Required.
        /// </summary>
        public IEnumerable<string> Rel { get; set; }

        /// <summary>
        /// Gets or sets a class descriptor. It describes aspects of the link based on the current representation. 
        /// Possible values are implementation-dependent and should be documented. MUST be an array of strings. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Class { get; set; }

        /// <summary>
        /// Gets or sets the URI of the linked resource. Required.
        /// </summary>
        public Uri Href { get; set; }

        /// <summary>
        /// Gets or sets a text describing the nature of a link. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the type. It defines media type of the linked resource, per Web Linking (RFC5988). Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }
}