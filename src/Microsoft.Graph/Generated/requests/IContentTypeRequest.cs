// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IContentTypeRequest.
    /// </summary>
    public partial interface IContentTypeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ContentType using POST.
        /// </summary>
        /// <param name="contentTypeToCreate">The ContentType to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ContentType.</returns>
        System.Threading.Tasks.Task<ContentType> CreateAsync(ContentType contentTypeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ContentType using POST and returns a <see cref="GraphResponse{ContentType}"/> object.
        /// </summary>
        /// <param name="contentTypeToCreate">The ContentType to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ContentType}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ContentType>> CreateResponseAsync(ContentType contentTypeToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ContentType.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ContentType and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ContentType.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ContentType.</returns>
        System.Threading.Tasks.Task<ContentType> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ContentType and returns a <see cref="GraphResponse{ContentType}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ContentType}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ContentType>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ContentType using PATCH.
        /// </summary>
        /// <param name="contentTypeToUpdate">The ContentType to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ContentType.</returns>
        System.Threading.Tasks.Task<ContentType> UpdateAsync(ContentType contentTypeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ContentType using PATCH and returns a <see cref="GraphResponse{ContentType}"/> object.
        /// </summary>
        /// <param name="contentTypeToUpdate">The ContentType to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ContentType}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ContentType>> UpdateResponseAsync(ContentType contentTypeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ContentType using PUT.
        /// </summary>
        /// <param name="contentTypeToUpdate">The ContentType object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ContentType> PutAsync(ContentType contentTypeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ContentType using PUT and returns a <see cref="GraphResponse{ContentType}"/> object.
        /// </summary>
        /// <param name="contentTypeToUpdate">The ContentType object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ContentType}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ContentType>> PutResponseAsync(ContentType contentTypeToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IContentTypeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IContentTypeRequest Expand(Expression<Func<ContentType, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IContentTypeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IContentTypeRequest Select(Expression<Func<ContentType, object>> selectExpression);

    }
}
