// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type RbacApplicationRequestBuilder.
    /// </summary>
    public partial class RbacApplicationRequestBuilder : EntityRequestBuilder, IRbacApplicationRequestBuilder
    {

        /// <summary>
        /// Constructs a new RbacApplicationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RbacApplicationRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRbacApplicationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRbacApplicationRequest Request(IEnumerable<Option> options)
        {
            return new RbacApplicationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        public IRbacApplicationRoleAssignmentsCollectionRequestBuilder RoleAssignments
        {
            get
            {
                return new RbacApplicationRoleAssignmentsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("roleAssignments"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RoleDefinitions.
        /// </summary>
        /// <returns>The <see cref="IRbacApplicationRoleDefinitionsCollectionRequestBuilder"/>.</returns>
        public IRbacApplicationRoleDefinitionsCollectionRequestBuilder RoleDefinitions
        {
            get
            {
                return new RbacApplicationRoleDefinitionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("roleDefinitions"), this.Client);
            }
        }
    
    }
}