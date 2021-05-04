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
    /// The type MeetingParticipantInfo.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class MeetingParticipantInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MeetingParticipantInfo"/> class.
        /// </summary>
        public MeetingParticipantInfo()
        {
            this.ODataType = "microsoft.graph.meetingParticipantInfo";
        }

        /// <summary>
        /// Gets or sets identity.
        /// Identity information of the participant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identity", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Identity { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Specifies the participant's role in the meeting.  Possible values are attendee, presenter, and unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "role", Required = Newtonsoft.Json.Required.Default)]
        public OnlineMeetingRole? Role { get; set; }
    
        /// <summary>
        /// Gets or sets upn.
        /// User principal name of the participant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "upn", Required = Newtonsoft.Json.Required.Default)]
        public string Upn { get; set; }
    
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
