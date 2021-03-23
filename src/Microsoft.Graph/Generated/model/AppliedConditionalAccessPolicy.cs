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
    /// The type AppliedConditionalAccessPolicy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AppliedConditionalAccessPolicy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppliedConditionalAccessPolicy"/> class.
        /// </summary>
        public AppliedConditionalAccessPolicy()
        {
            this.ODataType = "microsoft.graph.appliedConditionalAccessPolicy";
        }

        /// <summary>
        /// Gets or sets displayName.
        /// Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedGrantControls.
        /// Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforcedGrantControls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EnforcedGrantControls { get; set; }
    
        /// <summary>
        /// Gets or sets enforcedSessionControls.
        /// Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enforcedSessionControls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EnforcedSessionControls { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// An identifier of the conditional access policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Newtonsoft.Json.Required.Default)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets result.
        /// Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (Policy isn't applied because policy conditions were not met),notEnabled (This is due to the policy in disabled state), unknown, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "result", Required = Newtonsoft.Json.Required.Default)]
        public AppliedConditionalAccessPolicyResult? Result { get; set; }
    
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
