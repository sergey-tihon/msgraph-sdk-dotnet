// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Comms Operation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CommsOperation>))]
    public partial class CommsOperation : Entity
    {
    
        /// <summary>
        /// Gets or sets client context.
        /// Unique Client Context string. Max limit is 256 chars.
        /// </summary>
        [JsonPropertyName("clientContext")]
        public string ClientContext { get; set; }
    
        /// <summary>
        /// Gets or sets result info.
        /// The result information. Read-only.
        /// </summary>
        [JsonPropertyName("resultInfo")]
        public ResultInfo ResultInfo { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Possible values are: notStarted, running, completed, failed. Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public OperationStatus? Status { get; set; }
    
    }
}

