// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Nest
{
    public partial class ElasticClient : IElasticClient
    {
        public ClusterNamespace Cluster { get; private set; }

        public IndicesNamespace Indices { get; private set; }

        private partial void SetupNamespaces()
        {
            Cluster = new ClusterNamespace(this);
            Indices = new IndicesNamespace(this);
        }

        public PingResponse Ping(IPingRequest request)
        {
            return DoRequest<IPingRequest, PingResponse>(request, request.RequestParameters);
        }

        public Task<PingResponse> PingAsync(IPingRequest request, CancellationToken cancellationToken = default)
        {
            return DoRequestAsync<IPingRequest, PingResponse>(request, request.RequestParameters, cancellationToken);
        }
    }
}