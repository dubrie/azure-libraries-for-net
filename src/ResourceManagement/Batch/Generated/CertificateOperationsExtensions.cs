// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CertificateOperations.
    /// </summary>
    public static partial class CertificateOperationsExtensions
    {
            /// <summary>
            /// Lists all of the certificates in the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='maxresults'>
            /// The maximum number of items to return in the response.
            /// </param>
            /// <param name='select'>
            /// Comma separated list of properties that should be returned. e.g.
            /// "properties/provisioningState". Only top level properties under properties/
            /// are valid for selection.
            /// </param>
            /// <param name='filter'>
            /// OData filter expression. Valid properties for filtering are
            /// "properties/provisioningState",
            /// "properties/provisioningStateTransitionTime", "name".
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateInner>> ListByBatchAccountAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, int? maxresults = default(int?), string select = default(string), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBatchAccountWithHttpMessagesAsync(resourceGroupName, accountName, maxresults, select, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new certificate inside the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for certificate creation.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (ETag) version of the certificate to update. A value of
            /// "*" can be used to apply the operation only if the certificate already
            /// exists. If omitted, this operation will always be applied.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new certificate to be created, but to prevent
            /// updating an existing certificate. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> CreateAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CertificateCreateOrUpdateParametersInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the properties of an existing certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='parameters'>
            /// Certificate entity to update.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (ETag) version of the certificate to update. This value
            /// can be omitted or set to "*" to apply the operation unconditionally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> UpdateAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CertificateCreateOrUpdateParametersInner parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateDeleteHeadersInner> DeleteAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets information about the specified certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> GetAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels a failed deletion of a certificate from the specified account.
            /// </summary>
            /// <remarks>
            /// If you try to delete a certificate that is being used by a pool or compute
            /// node, the status of the certificate changes to deleteFailed. If you decide
            /// that you want to continue using the certificate, you can use this operation
            /// to set the status of the certificate back to active. If you intend to
            /// delete the certificate, you do not need to run this operation after the
            /// deletion failed. You must make sure that the certificate is not being used
            /// by any resources, and then you can try again to delete the certificate.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> CancelDeletionAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CancelDeletionWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new certificate inside the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='parameters'>
            /// Additional parameters for certificate creation.
            /// </param>
            /// <param name='ifMatch'>
            /// The entity state (ETag) version of the certificate to update. A value of
            /// "*" can be used to apply the operation only if the certificate already
            /// exists. If omitted, this operation will always be applied.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new certificate to be created, but to prevent
            /// updating an existing certificate. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateInner> BeginCreateAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CertificateCreateOrUpdateParametersInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified certificate.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the Batch account.
            /// </param>
            /// <param name='accountName'>
            /// The name of the Batch account.
            /// </param>
            /// <param name='certificateName'>
            /// The identifier for the certificate. This must be made up of algorithm and
            /// thumbprint separated by a dash, and must match the certificate data in the
            /// request. For example SHA1-a3d1c5.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CertificateDeleteHeadersInner> BeginDeleteAsync(this ICertificateOperations operations, string resourceGroupName, string accountName, string certificateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, certificateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists all of the certificates in the specified account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CertificateInner>> ListByBatchAccountNextAsync(this ICertificateOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByBatchAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
