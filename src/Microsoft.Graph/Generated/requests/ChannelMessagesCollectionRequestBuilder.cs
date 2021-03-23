// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ChannelMessagesCollectionRequestBuilder.
    /// </summary>
    public partial class ChannelMessagesCollectionRequestBuilder : BaseRequestBuilder, IChannelMessagesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ChannelMessagesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ChannelMessagesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IChannelMessagesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IChannelMessagesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ChannelMessagesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IChatMessageRequestBuilder"/> for the specified ChannelChatMessage.
        /// </summary>
        /// <param name="id">The ID for the ChannelChatMessage.</param>
        /// <returns>The <see cref="IChatMessageRequestBuilder"/>.</returns>
        public IChatMessageRequestBuilder this[string id]
        {
            get
            {
                return new ChatMessageRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ChatMessageDelta.
        /// </summary>
        /// <returns>The <see cref="IChatMessageDeltaRequestBuilder"/>.</returns>
        public IChatMessageDeltaRequestBuilder Delta()
        {
            return new ChatMessageDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
