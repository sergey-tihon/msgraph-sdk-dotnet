// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type OnenotePatchContentCommand.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class OnenotePatchContentCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnenotePatchContentCommand"/> class.
        /// </summary>
        public OnenotePatchContentCommand()
        {
            this.ODataType = "microsoft.graph.onenotePatchContentCommand";
        }

        /// <summary>
        /// Gets or sets action.
        /// The action to perform on the target element. The possible values are: replace, append, delete, insert, or prepend.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public OnenotePatchActionType? Action { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// A string of well-formed HTML to add to the page, and any image or file binary data. If the content contains binary data, the request must be sent using the multipart/form-data content type with a 'Commands' part.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public string Content { get; set; }
    
        /// <summary>
        /// Gets or sets position.
        /// The location to add the supplied content, relative to the target element. The possible values are: after (default) or before.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "position", Required = Newtonsoft.Json.Required.Default)]
        public OnenotePatchInsertPosition? Position { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The element to update. Must be the #&amp;lt;data-id&amp;gt; or the generated &amp;lt;id&amp;gt; of the element, or the body or title keyword.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "target", Required = Newtonsoft.Json.Required.Default)]
        public string Target { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
