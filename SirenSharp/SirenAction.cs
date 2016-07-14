namespace SirenSharp
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Actions show available behaviors an entity exposes.
    /// </summary>
    public class SirenAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SirenAction"/> class with required properties.
        /// </summary>
        /// <param name="name">Name of the action</param>
        /// <param name="href">Hypermedia reference</param>
        public SirenAction(string name, Uri href)
        {
            this.Name = name;
            this.Class = null;
            this.Method = HttpVerbs.Get;
            this.Href = href;
            this.Title = null;
            this.Type = "application/x-www-form-urlencoded";
            this.Fields = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SirenAction"/> class with required properties.
        /// </summary>
        /// <param name="name">Name of the action</param>
        /// <param name="href">Hypermedia reference</param>
        public SirenAction(string name, string href)
        {
            this.Name = name;
            this.Class = null;
            this.Method = HttpVerbs.Get;
            this.Href = new Uri(href, UriKind.RelativeOrAbsolute);
            this.Title = null;
            this.Type = "application/x-www-form-urlencoded";
            this.Fields = null;
        }

        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        /// <remarks>
        /// A string that identifies the action to be performed. Required.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of classes
        /// </summary>
        /// <remarks>
        /// Describes the nature of an action based on the current representation. 
        /// Possible values are implementation-dependent and should be documented. 
        /// MUST be an array of strings. Optional.
        /// </remarks>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<string> Class { get; set; }

        /// <summary>
        /// Gets or sets the method type
        /// </summary>
        /// <remarks>
        /// An enumerated attribute mapping to a protocol method. For HTTP, these values may be 
        /// GET, PUT, POST, DELETE, or PATCH. As new methods are introduced, this list can be 
        /// extended. If this attribute is omitted, GET should be assumed. Optional.
        /// </remarks>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public HttpVerbs Method { get; set; }

        /// <summary>
        /// Gets or sets the hypermedia reference to the action
        /// </summary>
        /// <remarks>
        /// The URI of the action. Required.
        /// </remarks>
        public Uri Href { get; set; }

        /// <summary>
        /// Gets or sets a descriptive text about the action. Optional.
        /// </summary>
        /// <remarks>
        /// Descriptive text about the action. Optional.
        /// </remarks>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the encoding type expected by the action.
        /// </summary>
        /// <remarks>
        /// The encoding type for the request. When omitted and the fields attribute exists, 
        /// the default value is application/x-www-form-urlencoded. Optional.
        /// </remarks>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the fields associated with this action.
        /// </summary>
        /// <remarks>
        /// A collection of fields, expressed as an array of objects in JSON Siren 
        /// such as { "fields" : [{ ... }] }. See Fields. Optional.
        /// </remarks>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SirenField> Fields { get; set; }
    }
}
