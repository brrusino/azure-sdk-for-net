// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    internal class SynapseClusterPrincipalAssignmentOperationSource : IOperationSource<SynapseClusterPrincipalAssignmentResource>
    {
        private readonly ArmClient _client;

        internal SynapseClusterPrincipalAssignmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        SynapseClusterPrincipalAssignmentResource IOperationSource<SynapseClusterPrincipalAssignmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SynapseClusterPrincipalAssignmentData.DeserializeSynapseClusterPrincipalAssignmentData(document.RootElement);
            return new SynapseClusterPrincipalAssignmentResource(_client, data);
        }

        async ValueTask<SynapseClusterPrincipalAssignmentResource> IOperationSource<SynapseClusterPrincipalAssignmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SynapseClusterPrincipalAssignmentData.DeserializeSynapseClusterPrincipalAssignmentData(document.RootElement);
            return new SynapseClusterPrincipalAssignmentResource(_client, data);
        }
    }
}
