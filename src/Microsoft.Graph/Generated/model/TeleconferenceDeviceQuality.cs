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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type TeleconferenceDeviceQuality.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeleconferenceDeviceQuality>))]
    public partial class TeleconferenceDeviceQuality
    {

        /// <summary>
        /// Gets or sets callChainId.
        /// A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.
        /// </summary>
        [JsonPropertyName("callChainId")]
        public Guid? CallChainId { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceDeploymentEnvironment.
        /// A geo-region where the service is deployed, such as ProdNoam.
        /// </summary>
        [JsonPropertyName("cloudServiceDeploymentEnvironment")]
        public string CloudServiceDeploymentEnvironment { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceDeploymentId.
        /// A unique deployment identifier assigned by Azure.
        /// </summary>
        [JsonPropertyName("cloudServiceDeploymentId")]
        public string CloudServiceDeploymentId { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceInstanceName.
        /// The Azure deployed cloud service instance name, such as FrontEnd_IN_3.
        /// </summary>
        [JsonPropertyName("cloudServiceInstanceName")]
        public string CloudServiceInstanceName { get; set; }
    
        /// <summary>
        /// Gets or sets cloudServiceName.
        /// The Azure deployed cloud service name, such as contoso.cloudapp.net.
        /// </summary>
        [JsonPropertyName("cloudServiceName")]
        public string CloudServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets deviceDescription.
        /// Any additional description, such as VTC Bldg 30/21.
        /// </summary>
        [JsonPropertyName("deviceDescription")]
        public string DeviceDescription { get; set; }
    
        /// <summary>
        /// Gets or sets deviceName.
        /// The user media agent name, such as Cisco SX80.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets mediaLegId.
        /// A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.
        /// </summary>
        [JsonPropertyName("mediaLegId")]
        public Guid? MediaLegId { get; set; }
    
        /// <summary>
        /// Gets or sets mediaQualityList.
        /// The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.
        /// </summary>
        [JsonPropertyName("mediaQualityList")]
        public IEnumerable<TeleconferenceDeviceMediaQuality> MediaQualityList { get; set; }
    
        /// <summary>
        /// Gets or sets participantId.
        /// A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.
        /// </summary>
        [JsonPropertyName("participantId")]
        public Guid? ParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
