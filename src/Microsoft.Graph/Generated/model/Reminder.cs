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
    /// The type Reminder.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Reminder>))]
    public partial class Reminder
    {

        /// <summary>
        /// Gets or sets changeKey.
        /// Identifies the version of the reminder. Every time the reminder is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object.
        /// </summary>
        [JsonPropertyName("changeKey")]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets eventEndTime.
        /// The date, time and time zone that the event ends.
        /// </summary>
        [JsonPropertyName("eventEndTime")]
        public DateTimeTimeZone EventEndTime { get; set; }
    
        /// <summary>
        /// Gets or sets eventId.
        /// The unique ID of the event. Read only.
        /// </summary>
        [JsonPropertyName("eventId")]
        public string EventId { get; set; }
    
        /// <summary>
        /// Gets or sets eventLocation.
        /// The location of the event.
        /// </summary>
        [JsonPropertyName("eventLocation")]
        public Location EventLocation { get; set; }
    
        /// <summary>
        /// Gets or sets eventStartTime.
        /// The date, time, and time zone that the event starts.
        /// </summary>
        [JsonPropertyName("eventStartTime")]
        public DateTimeTimeZone EventStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets eventSubject.
        /// The text of the event's subject line.
        /// </summary>
        [JsonPropertyName("eventSubject")]
        public string EventSubject { get; set; }
    
        /// <summary>
        /// Gets or sets eventWebLink.
        /// The URL to open the event in Outlook on the web.The event will open in the browser if you are logged in to your mailbox via Outlook on the web. You will be prompted to login if you are not already logged in with the browser.This URL cannot be accessed from within an iFrame.
        /// </summary>
        [JsonPropertyName("eventWebLink")]
        public string EventWebLink { get; set; }
    
        /// <summary>
        /// Gets or sets reminderFireTime.
        /// The date, time, and time zone that the reminder is set to occur.
        /// </summary>
        [JsonPropertyName("reminderFireTime")]
        public DateTimeTimeZone ReminderFireTime { get; set; }
    
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
