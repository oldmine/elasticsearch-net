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
//
// ------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public class ClusterNamespace : NamespacedClientProxy
	{
		internal ClusterNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public ClusterAllocationExplainResponse AllocationExplain(ClusterAllocationExplainRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterAllocationExplainRequest, ClusterAllocationExplainResponse>(request);
		}

		public Task<ClusterAllocationExplainResponse> AllocationExplainAsync(ClusterAllocationExplainRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterAllocationExplainRequest, ClusterAllocationExplainResponse>(request, cancellationToken);
		}

		public ClusterAllocationExplainResponse AllocationExplain()
		{
			var descriptor = new ClusterAllocationExplainRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterAllocationExplainRequestDescriptor, ClusterAllocationExplainResponse>(descriptor);
		}

		public ClusterAllocationExplainResponse AllocationExplain(Action<ClusterAllocationExplainRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterAllocationExplainRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterAllocationExplainRequestDescriptor, ClusterAllocationExplainResponse>(descriptor);
		}

		public Task<ClusterAllocationExplainResponse> AllocationExplainAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterAllocationExplainRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterAllocationExplainRequestDescriptor, ClusterAllocationExplainResponse>(descriptor);
		}

		public Task<ClusterAllocationExplainResponse> AllocationExplainAsync(Action<ClusterAllocationExplainRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterAllocationExplainRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterAllocationExplainRequestDescriptor, ClusterAllocationExplainResponse>(descriptor);
		}

		public ClusterDeleteComponentTemplateResponse DeleteComponentTemplate(ClusterDeleteComponentTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterDeleteComponentTemplateRequest, ClusterDeleteComponentTemplateResponse>(request);
		}

		public Task<ClusterDeleteComponentTemplateResponse> DeleteComponentTemplateAsync(ClusterDeleteComponentTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterDeleteComponentTemplateRequest, ClusterDeleteComponentTemplateResponse>(request, cancellationToken);
		}

		public ClusterDeleteComponentTemplateResponse DeleteComponentTemplate(Elastic.Clients.Elasticsearch.Names name)
		{
			var descriptor = new ClusterDeleteComponentTemplateRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequest<ClusterDeleteComponentTemplateRequestDescriptor, ClusterDeleteComponentTemplateResponse>(descriptor);
		}

		public ClusterDeleteComponentTemplateResponse DeleteComponentTemplate(Elastic.Clients.Elasticsearch.Names name, Action<ClusterDeleteComponentTemplateRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterDeleteComponentTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterDeleteComponentTemplateRequestDescriptor, ClusterDeleteComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterDeleteComponentTemplateResponse> DeleteComponentTemplateAsync(Elastic.Clients.Elasticsearch.Names name, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterDeleteComponentTemplateRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterDeleteComponentTemplateRequestDescriptor, ClusterDeleteComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterDeleteComponentTemplateResponse> DeleteComponentTemplateAsync(Elastic.Clients.Elasticsearch.Names name, Action<ClusterDeleteComponentTemplateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterDeleteComponentTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterDeleteComponentTemplateRequestDescriptor, ClusterDeleteComponentTemplateResponse>(descriptor);
		}

		public ClusterDeleteVotingConfigExclusionsResponse DeleteVotingConfigExclusions(ClusterDeleteVotingConfigExclusionsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterDeleteVotingConfigExclusionsRequest, ClusterDeleteVotingConfigExclusionsResponse>(request);
		}

		public Task<ClusterDeleteVotingConfigExclusionsResponse> DeleteVotingConfigExclusionsAsync(ClusterDeleteVotingConfigExclusionsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterDeleteVotingConfigExclusionsRequest, ClusterDeleteVotingConfigExclusionsResponse>(request, cancellationToken);
		}

		public ClusterDeleteVotingConfigExclusionsResponse DeleteVotingConfigExclusions()
		{
			var descriptor = new ClusterDeleteVotingConfigExclusionsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterDeleteVotingConfigExclusionsRequestDescriptor, ClusterDeleteVotingConfigExclusionsResponse>(descriptor);
		}

		public ClusterDeleteVotingConfigExclusionsResponse DeleteVotingConfigExclusions(Action<ClusterDeleteVotingConfigExclusionsRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterDeleteVotingConfigExclusionsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterDeleteVotingConfigExclusionsRequestDescriptor, ClusterDeleteVotingConfigExclusionsResponse>(descriptor);
		}

		public Task<ClusterDeleteVotingConfigExclusionsResponse> DeleteVotingConfigExclusionsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterDeleteVotingConfigExclusionsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterDeleteVotingConfigExclusionsRequestDescriptor, ClusterDeleteVotingConfigExclusionsResponse>(descriptor);
		}

		public Task<ClusterDeleteVotingConfigExclusionsResponse> DeleteVotingConfigExclusionsAsync(Action<ClusterDeleteVotingConfigExclusionsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterDeleteVotingConfigExclusionsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterDeleteVotingConfigExclusionsRequestDescriptor, ClusterDeleteVotingConfigExclusionsResponse>(descriptor);
		}

		public ClusterExistsComponentTemplateResponse ExistsComponentTemplate(ClusterExistsComponentTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterExistsComponentTemplateRequest, ClusterExistsComponentTemplateResponse>(request);
		}

		public Task<ClusterExistsComponentTemplateResponse> ExistsComponentTemplateAsync(ClusterExistsComponentTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterExistsComponentTemplateRequest, ClusterExistsComponentTemplateResponse>(request, cancellationToken);
		}

		public ClusterExistsComponentTemplateResponse ExistsComponentTemplate(Elastic.Clients.Elasticsearch.Names name)
		{
			var descriptor = new ClusterExistsComponentTemplateRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequest<ClusterExistsComponentTemplateRequestDescriptor, ClusterExistsComponentTemplateResponse>(descriptor);
		}

		public ClusterExistsComponentTemplateResponse ExistsComponentTemplate(Elastic.Clients.Elasticsearch.Names name, Action<ClusterExistsComponentTemplateRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterExistsComponentTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterExistsComponentTemplateRequestDescriptor, ClusterExistsComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterExistsComponentTemplateResponse> ExistsComponentTemplateAsync(Elastic.Clients.Elasticsearch.Names name, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterExistsComponentTemplateRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterExistsComponentTemplateRequestDescriptor, ClusterExistsComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterExistsComponentTemplateResponse> ExistsComponentTemplateAsync(Elastic.Clients.Elasticsearch.Names name, Action<ClusterExistsComponentTemplateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterExistsComponentTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterExistsComponentTemplateRequestDescriptor, ClusterExistsComponentTemplateResponse>(descriptor);
		}

		public ClusterGetComponentTemplateResponse GetComponentTemplate(ClusterGetComponentTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterGetComponentTemplateRequest, ClusterGetComponentTemplateResponse>(request);
		}

		public Task<ClusterGetComponentTemplateResponse> GetComponentTemplateAsync(ClusterGetComponentTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterGetComponentTemplateRequest, ClusterGetComponentTemplateResponse>(request, cancellationToken);
		}

		public ClusterGetComponentTemplateResponse GetComponentTemplate()
		{
			var descriptor = new ClusterGetComponentTemplateRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterGetComponentTemplateRequestDescriptor, ClusterGetComponentTemplateResponse>(descriptor);
		}

		public ClusterGetComponentTemplateResponse GetComponentTemplate(Action<ClusterGetComponentTemplateRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterGetComponentTemplateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterGetComponentTemplateRequestDescriptor, ClusterGetComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterGetComponentTemplateResponse> GetComponentTemplateAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterGetComponentTemplateRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterGetComponentTemplateRequestDescriptor, ClusterGetComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterGetComponentTemplateResponse> GetComponentTemplateAsync(Action<ClusterGetComponentTemplateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterGetComponentTemplateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterGetComponentTemplateRequestDescriptor, ClusterGetComponentTemplateResponse>(descriptor);
		}

		public ClusterGetSettingsResponse GetSettings(ClusterGetSettingsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterGetSettingsRequest, ClusterGetSettingsResponse>(request);
		}

		public Task<ClusterGetSettingsResponse> GetSettingsAsync(ClusterGetSettingsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterGetSettingsRequest, ClusterGetSettingsResponse>(request, cancellationToken);
		}

		public ClusterGetSettingsResponse GetSettings()
		{
			var descriptor = new ClusterGetSettingsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterGetSettingsRequestDescriptor, ClusterGetSettingsResponse>(descriptor);
		}

		public ClusterGetSettingsResponse GetSettings(Action<ClusterGetSettingsRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterGetSettingsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterGetSettingsRequestDescriptor, ClusterGetSettingsResponse>(descriptor);
		}

		public Task<ClusterGetSettingsResponse> GetSettingsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterGetSettingsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterGetSettingsRequestDescriptor, ClusterGetSettingsResponse>(descriptor);
		}

		public Task<ClusterGetSettingsResponse> GetSettingsAsync(Action<ClusterGetSettingsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterGetSettingsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterGetSettingsRequestDescriptor, ClusterGetSettingsResponse>(descriptor);
		}

		public ClusterHealthResponse Health(ClusterHealthRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterHealthRequest, ClusterHealthResponse>(request);
		}

		public Task<ClusterHealthResponse> HealthAsync(ClusterHealthRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterHealthRequest, ClusterHealthResponse>(request, cancellationToken);
		}

		public ClusterHealthResponse Health()
		{
			var descriptor = new ClusterHealthRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
		}

		public ClusterHealthResponse Health(Action<ClusterHealthRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterHealthRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
		}

		public ClusterHealthResponse Health<TDocument>(Action<ClusterHealthRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new ClusterHealthRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterHealthRequestDescriptor<TDocument>, ClusterHealthResponse>(descriptor);
		}

		public Task<ClusterHealthResponse> HealthAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterHealthRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
		}

		public Task<ClusterHealthResponse> HealthAsync(Action<ClusterHealthRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterHealthRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterHealthRequestDescriptor, ClusterHealthResponse>(descriptor);
		}

		public Task<ClusterHealthResponse> HealthAsync<TDocument>(Action<ClusterHealthRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterHealthRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterHealthRequestDescriptor<TDocument>, ClusterHealthResponse>(descriptor);
		}

		public ClusterPendingTasksResponse PendingTasks(ClusterPendingTasksRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterPendingTasksRequest, ClusterPendingTasksResponse>(request);
		}

		public Task<ClusterPendingTasksResponse> PendingTasksAsync(ClusterPendingTasksRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterPendingTasksRequest, ClusterPendingTasksResponse>(request, cancellationToken);
		}

		public ClusterPendingTasksResponse PendingTasks()
		{
			var descriptor = new ClusterPendingTasksRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksResponse>(descriptor);
		}

		public ClusterPendingTasksResponse PendingTasks(Action<ClusterPendingTasksRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterPendingTasksRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksResponse>(descriptor);
		}

		public Task<ClusterPendingTasksResponse> PendingTasksAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPendingTasksRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksResponse>(descriptor);
		}

		public Task<ClusterPendingTasksResponse> PendingTasksAsync(Action<ClusterPendingTasksRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPendingTasksRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksResponse>(descriptor);
		}

		public ClusterPostVotingConfigExclusionsResponse PostVotingConfigExclusions(ClusterPostVotingConfigExclusionsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterPostVotingConfigExclusionsRequest, ClusterPostVotingConfigExclusionsResponse>(request);
		}

		public Task<ClusterPostVotingConfigExclusionsResponse> PostVotingConfigExclusionsAsync(ClusterPostVotingConfigExclusionsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterPostVotingConfigExclusionsRequest, ClusterPostVotingConfigExclusionsResponse>(request, cancellationToken);
		}

		public ClusterPostVotingConfigExclusionsResponse PostVotingConfigExclusions()
		{
			var descriptor = new ClusterPostVotingConfigExclusionsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterPostVotingConfigExclusionsRequestDescriptor, ClusterPostVotingConfigExclusionsResponse>(descriptor);
		}

		public ClusterPostVotingConfigExclusionsResponse PostVotingConfigExclusions(Action<ClusterPostVotingConfigExclusionsRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterPostVotingConfigExclusionsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPostVotingConfigExclusionsRequestDescriptor, ClusterPostVotingConfigExclusionsResponse>(descriptor);
		}

		public Task<ClusterPostVotingConfigExclusionsResponse> PostVotingConfigExclusionsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPostVotingConfigExclusionsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPostVotingConfigExclusionsRequestDescriptor, ClusterPostVotingConfigExclusionsResponse>(descriptor);
		}

		public Task<ClusterPostVotingConfigExclusionsResponse> PostVotingConfigExclusionsAsync(Action<ClusterPostVotingConfigExclusionsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPostVotingConfigExclusionsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPostVotingConfigExclusionsRequestDescriptor, ClusterPostVotingConfigExclusionsResponse>(descriptor);
		}

		public ClusterPutComponentTemplateResponse PutComponentTemplate(ClusterPutComponentTemplateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterPutComponentTemplateRequest, ClusterPutComponentTemplateResponse>(request);
		}

		public Task<ClusterPutComponentTemplateResponse> PutComponentTemplateAsync(ClusterPutComponentTemplateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterPutComponentTemplateRequest, ClusterPutComponentTemplateResponse>(request, cancellationToken);
		}

		public ClusterPutComponentTemplateResponse PutComponentTemplate(Elastic.Clients.Elasticsearch.Name name)
		{
			var descriptor = new ClusterPutComponentTemplateRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPutComponentTemplateRequestDescriptor, ClusterPutComponentTemplateResponse>(descriptor);
		}

		public ClusterPutComponentTemplateResponse PutComponentTemplate(Elastic.Clients.Elasticsearch.Name name, Action<ClusterPutComponentTemplateRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterPutComponentTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPutComponentTemplateRequestDescriptor, ClusterPutComponentTemplateResponse>(descriptor);
		}

		public ClusterPutComponentTemplateResponse PutComponentTemplate<TDocument>(Elastic.Clients.Elasticsearch.Name name, Action<ClusterPutComponentTemplateRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new ClusterPutComponentTemplateRequestDescriptor<TDocument>(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPutComponentTemplateRequestDescriptor<TDocument>, ClusterPutComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterPutComponentTemplateResponse> PutComponentTemplateAsync(Elastic.Clients.Elasticsearch.Name name, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPutComponentTemplateRequestDescriptor(name);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPutComponentTemplateRequestDescriptor, ClusterPutComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterPutComponentTemplateResponse> PutComponentTemplateAsync(Elastic.Clients.Elasticsearch.Name name, Action<ClusterPutComponentTemplateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPutComponentTemplateRequestDescriptor(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPutComponentTemplateRequestDescriptor, ClusterPutComponentTemplateResponse>(descriptor);
		}

		public Task<ClusterPutComponentTemplateResponse> PutComponentTemplateAsync<TDocument>(Elastic.Clients.Elasticsearch.Name name, Action<ClusterPutComponentTemplateRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPutComponentTemplateRequestDescriptor<TDocument>(name);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPutComponentTemplateRequestDescriptor<TDocument>, ClusterPutComponentTemplateResponse>(descriptor);
		}

		public ClusterPutSettingsResponse PutSettings(ClusterPutSettingsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterPutSettingsRequest, ClusterPutSettingsResponse>(request);
		}

		public Task<ClusterPutSettingsResponse> PutSettingsAsync(ClusterPutSettingsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterPutSettingsRequest, ClusterPutSettingsResponse>(request, cancellationToken);
		}

		public ClusterPutSettingsResponse PutSettings()
		{
			var descriptor = new ClusterPutSettingsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterPutSettingsRequestDescriptor, ClusterPutSettingsResponse>(descriptor);
		}

		public ClusterPutSettingsResponse PutSettings(Action<ClusterPutSettingsRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterPutSettingsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterPutSettingsRequestDescriptor, ClusterPutSettingsResponse>(descriptor);
		}

		public Task<ClusterPutSettingsResponse> PutSettingsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPutSettingsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPutSettingsRequestDescriptor, ClusterPutSettingsResponse>(descriptor);
		}

		public Task<ClusterPutSettingsResponse> PutSettingsAsync(Action<ClusterPutSettingsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterPutSettingsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterPutSettingsRequestDescriptor, ClusterPutSettingsResponse>(descriptor);
		}

		public ClusterRemoteInfoResponse RemoteInfo(ClusterRemoteInfoRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterRemoteInfoRequest, ClusterRemoteInfoResponse>(request);
		}

		public Task<ClusterRemoteInfoResponse> RemoteInfoAsync(ClusterRemoteInfoRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterRemoteInfoRequest, ClusterRemoteInfoResponse>(request, cancellationToken);
		}

		public ClusterRemoteInfoResponse RemoteInfo()
		{
			var descriptor = new ClusterRemoteInfoRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterRemoteInfoRequestDescriptor, ClusterRemoteInfoResponse>(descriptor);
		}

		public ClusterRemoteInfoResponse RemoteInfo(Action<ClusterRemoteInfoRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterRemoteInfoRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterRemoteInfoRequestDescriptor, ClusterRemoteInfoResponse>(descriptor);
		}

		public Task<ClusterRemoteInfoResponse> RemoteInfoAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterRemoteInfoRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterRemoteInfoRequestDescriptor, ClusterRemoteInfoResponse>(descriptor);
		}

		public Task<ClusterRemoteInfoResponse> RemoteInfoAsync(Action<ClusterRemoteInfoRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterRemoteInfoRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterRemoteInfoRequestDescriptor, ClusterRemoteInfoResponse>(descriptor);
		}

		public ClusterRerouteResponse Reroute(ClusterRerouteRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterRerouteRequest, ClusterRerouteResponse>(request);
		}

		public Task<ClusterRerouteResponse> RerouteAsync(ClusterRerouteRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterRerouteRequest, ClusterRerouteResponse>(request, cancellationToken);
		}

		public ClusterRerouteResponse Reroute()
		{
			var descriptor = new ClusterRerouteRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterRerouteRequestDescriptor, ClusterRerouteResponse>(descriptor);
		}

		public ClusterRerouteResponse Reroute(Action<ClusterRerouteRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterRerouteRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterRerouteRequestDescriptor, ClusterRerouteResponse>(descriptor);
		}

		public Task<ClusterRerouteResponse> RerouteAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterRerouteRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterRerouteRequestDescriptor, ClusterRerouteResponse>(descriptor);
		}

		public Task<ClusterRerouteResponse> RerouteAsync(Action<ClusterRerouteRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterRerouteRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterRerouteRequestDescriptor, ClusterRerouteResponse>(descriptor);
		}

		public ClusterStateResponse State(ClusterStateRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterStateRequest, ClusterStateResponse>(request);
		}

		public Task<ClusterStateResponse> StateAsync(ClusterStateRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterStateRequest, ClusterStateResponse>(request, cancellationToken);
		}

		public ClusterStateResponse State()
		{
			var descriptor = new ClusterStateRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterStateRequestDescriptor, ClusterStateResponse>(descriptor);
		}

		public ClusterStateResponse State(Action<ClusterStateRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterStateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterStateRequestDescriptor, ClusterStateResponse>(descriptor);
		}

		public ClusterStateResponse State<TDocument>(Action<ClusterStateRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new ClusterStateRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterStateRequestDescriptor<TDocument>, ClusterStateResponse>(descriptor);
		}

		public Task<ClusterStateResponse> StateAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterStateRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterStateRequestDescriptor, ClusterStateResponse>(descriptor);
		}

		public Task<ClusterStateResponse> StateAsync(Action<ClusterStateRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterStateRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterStateRequestDescriptor, ClusterStateResponse>(descriptor);
		}

		public Task<ClusterStateResponse> StateAsync<TDocument>(Action<ClusterStateRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterStateRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterStateRequestDescriptor<TDocument>, ClusterStateResponse>(descriptor);
		}

		public ClusterStatsResponse Stats(ClusterStatsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClusterStatsRequest, ClusterStatsResponse>(request);
		}

		public Task<ClusterStatsResponse> StatsAsync(ClusterStatsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClusterStatsRequest, ClusterStatsResponse>(request, cancellationToken);
		}

		public ClusterStatsResponse Stats()
		{
			var descriptor = new ClusterStatsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<ClusterStatsRequestDescriptor, ClusterStatsResponse>(descriptor);
		}

		public ClusterStatsResponse Stats(Action<ClusterStatsRequestDescriptor> configureRequest)
		{
			var descriptor = new ClusterStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClusterStatsRequestDescriptor, ClusterStatsResponse>(descriptor);
		}

		public Task<ClusterStatsResponse> StatsAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterStatsRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterStatsRequestDescriptor, ClusterStatsResponse>(descriptor);
		}

		public Task<ClusterStatsResponse> StatsAsync(Action<ClusterStatsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClusterStatsRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClusterStatsRequestDescriptor, ClusterStatsResponse>(descriptor);
		}
	}
}