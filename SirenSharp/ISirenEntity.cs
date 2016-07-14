using Newtonsoft.Json;

namespace SirenSharp
{
    using System.Collections.Generic;

    /// <summary>
    /// Siren is a hypermedia specification for representing entities. As HTML is used for visually 
    /// representing documents on a Web site, Siren is a specification for presenting entities via 
    /// a Web API. Siren offers structures to communicate information about entities, actions for 
    /// executing state transitions, and links for client navigation.
    /// </summary>
    /// <remarks>
    /// Based on version 0.6.1
    /// https://github.com/kevinswiber/siren
    /// </remarks>
    public interface ISirenEntity
    {
        /// <summary>
        /// Gets a list of content classes. It describes the nature of an entity's content based on the current representation. 
        /// Possible values are implementation-dependent and should be documented. MUST be an array of strings. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        IList<string> Class { get; }

        /// <summary>
        /// Gets a set of key-value pairs that describe the state of an entity. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        dynamic Properties { get; }

        /// <summary>
        /// Gets a collection of related sub-entities. If a sub-entity contains an href value, it should be treated as an embedded link.
        /// Clients may choose to optimistically load embedded links. If no href value exists, the sub-entity is an embedded entity 
        /// representation that contains all the characteristics of a typical entity. One difference is that a sub-entity MUST contain
        /// a rel attribute to describe its relationship to the parent entity. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, ReferenceLoopHandling = ReferenceLoopHandling.Ignore)]
        IList<SirenSubEntity> Entities { get; }

        /// <summary>
        /// Gets a collection of items that describe navigational links, distinct from entity relationships. Link
        /// items should contain a rel attribute to describe the relationship and an href attribute to point to 
        /// the target URI. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        IList<SirenLink> Links { get; }

        /// <summary>
        /// Gets a collection of action objects. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        IList<SirenAction> Actions { get; }

        /// <summary>
        /// Gets a descriptive text about the entity. Optional.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        string Title { get; }
    }
}
