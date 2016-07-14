namespace SirenSharp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the Siren sub-entity wrapper.
    /// </summary>
    public class SirenSubEntity : SirenEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SirenSubEntity"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference</param>
        /// <param name="rel">Unique relationship</param>
        public SirenSubEntity(Uri href, params string[] rel)
        {
            this.Rel = rel;
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SirenSubEntity"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference</param>
        /// <param name="rel">Unique relationship</param>
        public SirenSubEntity(string href, params string[] rel)
        {
            this.Rel = rel;
            this.Href = new Uri(href, UriKind.RelativeOrAbsolute);
        }

        /// <summary>
        /// Gets or sets the unique relationship for getting entities associated with this sub-entity.
        /// A client would use these to find the appropriate sub-entity href to get.
        /// </summary>
        /// <remarks>
        /// Defines the relationship of the sub-entity to its parent, per Web Linking (RFC5899).
        /// MUST be an array of strings. Required.
        /// </remarks>
        public IEnumerable<string> Rel { get; set; }

        /// <summary>
        /// Gets or sets the hypermedia reference to the entities associated with this sub-entity.
        /// </summary>
        /// <remarks>
        /// The URI of the linked sub-entity. Required.
        /// </remarks>
        public Uri Href { get; set; }
    }
}
