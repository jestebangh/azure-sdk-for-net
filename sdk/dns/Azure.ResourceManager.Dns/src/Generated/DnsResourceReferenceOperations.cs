// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Dns.Models;

namespace Azure.ResourceManager.Dns
{
    /// <summary> The DnsResourceReference service client. </summary>
    public partial class DnsResourceReferenceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DnsResourceReferenceRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of DnsResourceReferenceOperations for mocking. </summary>
        protected DnsResourceReferenceOperations()
        {
        }
        /// <summary> Initializes a new instance of DnsResourceReferenceOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Specifies the Azure subscription ID, which uniquely identifies the Microsoft Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DnsResourceReferenceOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2018-05-01")
        {
            RestClient = new DnsResourceReferenceRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Returns the DNS records specified by the referencing targetResourceIds. </summary>
        /// <param name="parameters"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DnsResourceReferenceResult>> GetByTargetResourcesAsync(DnsResourceReferenceRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DnsResourceReferenceOperations.GetByTargetResources");
            scope.Start();
            try
            {
                return await RestClient.GetByTargetResourcesAsync(parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Returns the DNS records specified by the referencing targetResourceIds. </summary>
        /// <param name="parameters"> Properties for dns resource reference request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DnsResourceReferenceResult> GetByTargetResources(DnsResourceReferenceRequest parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DnsResourceReferenceOperations.GetByTargetResources");
            scope.Start();
            try
            {
                return RestClient.GetByTargetResources(parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
