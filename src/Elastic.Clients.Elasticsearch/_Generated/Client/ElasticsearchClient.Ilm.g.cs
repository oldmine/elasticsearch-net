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
namespace Elastic.Clients.Elasticsearch.Ilm
{
	public class IlmNamespace : NamespacedClientProxy
	{
		internal IlmNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public IlmDeleteLifecycleResponse DeleteLifecycle(IlmDeleteLifecycleRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmDeleteLifecycleRequest, IlmDeleteLifecycleResponse>(request);
		}

		public Task<IlmDeleteLifecycleResponse> DeleteLifecycleAsync(IlmDeleteLifecycleRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmDeleteLifecycleRequest, IlmDeleteLifecycleResponse>(request, cancellationToken);
		}

		public IlmDeleteLifecycleResponse DeleteLifecycle(Elastic.Clients.Elasticsearch.Name policy)
		{
			var descriptor = new IlmDeleteLifecycleRequestDescriptor(policy);
			descriptor.BeforeRequest();
			return DoRequest<IlmDeleteLifecycleRequestDescriptor, IlmDeleteLifecycleResponse>(descriptor);
		}

		public IlmDeleteLifecycleResponse DeleteLifecycle(Elastic.Clients.Elasticsearch.Name policy, Action<IlmDeleteLifecycleRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmDeleteLifecycleRequestDescriptor(policy);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmDeleteLifecycleRequestDescriptor, IlmDeleteLifecycleResponse>(descriptor);
		}

		public Task<IlmDeleteLifecycleResponse> DeleteLifecycleAsync(Elastic.Clients.Elasticsearch.Name policy, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmDeleteLifecycleRequestDescriptor(policy);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmDeleteLifecycleRequestDescriptor, IlmDeleteLifecycleResponse>(descriptor);
		}

		public Task<IlmDeleteLifecycleResponse> DeleteLifecycleAsync(Elastic.Clients.Elasticsearch.Name policy, Action<IlmDeleteLifecycleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmDeleteLifecycleRequestDescriptor(policy);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmDeleteLifecycleRequestDescriptor, IlmDeleteLifecycleResponse>(descriptor);
		}

		public IlmExplainLifecycleResponse ExplainLifecycle(IlmExplainLifecycleRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmExplainLifecycleRequest, IlmExplainLifecycleResponse>(request);
		}

		public Task<IlmExplainLifecycleResponse> ExplainLifecycleAsync(IlmExplainLifecycleRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmExplainLifecycleRequest, IlmExplainLifecycleResponse>(request, cancellationToken);
		}

		public IlmExplainLifecycleResponse ExplainLifecycle(Elastic.Clients.Elasticsearch.IndexName index)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequest<IlmExplainLifecycleRequestDescriptor, IlmExplainLifecycleResponse>(descriptor);
		}

		public IlmExplainLifecycleResponse ExplainLifecycle(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmExplainLifecycleRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmExplainLifecycleRequestDescriptor, IlmExplainLifecycleResponse>(descriptor);
		}

		public IlmExplainLifecycleResponse ExplainLifecycle<TDocument>()
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequest<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleResponse>(descriptor);
		}

		public IlmExplainLifecycleResponse ExplainLifecycle<TDocument>(Action<IlmExplainLifecycleRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleResponse>(descriptor);
		}

		public IlmExplainLifecycleResponse ExplainLifecycle<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmExplainLifecycleRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleResponse>(descriptor);
		}

		public Task<IlmExplainLifecycleResponse> ExplainLifecycleAsync(Elastic.Clients.Elasticsearch.IndexName index, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmExplainLifecycleRequestDescriptor, IlmExplainLifecycleResponse>(descriptor);
		}

		public Task<IlmExplainLifecycleResponse> ExplainLifecycleAsync(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmExplainLifecycleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmExplainLifecycleRequestDescriptor, IlmExplainLifecycleResponse>(descriptor);
		}

		public Task<IlmExplainLifecycleResponse> ExplainLifecycleAsync<TDocument>(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleResponse>(descriptor);
		}

		public Task<IlmExplainLifecycleResponse> ExplainLifecycleAsync<TDocument>(Action<IlmExplainLifecycleRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleResponse>(descriptor);
		}

		public Task<IlmExplainLifecycleResponse> ExplainLifecycleAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmExplainLifecycleRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmExplainLifecycleRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmExplainLifecycleRequestDescriptor<TDocument>, IlmExplainLifecycleResponse>(descriptor);
		}

		public IlmGetLifecycleResponse GetLifecycle(IlmGetLifecycleRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmGetLifecycleRequest, IlmGetLifecycleResponse>(request);
		}

		public Task<IlmGetLifecycleResponse> GetLifecycleAsync(IlmGetLifecycleRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmGetLifecycleRequest, IlmGetLifecycleResponse>(request, cancellationToken);
		}

		public IlmGetLifecycleResponse GetLifecycle()
		{
			var descriptor = new IlmGetLifecycleRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<IlmGetLifecycleRequestDescriptor, IlmGetLifecycleResponse>(descriptor);
		}

		public IlmGetLifecycleResponse GetLifecycle(Action<IlmGetLifecycleRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmGetLifecycleRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmGetLifecycleRequestDescriptor, IlmGetLifecycleResponse>(descriptor);
		}

		public Task<IlmGetLifecycleResponse> GetLifecycleAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmGetLifecycleRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmGetLifecycleRequestDescriptor, IlmGetLifecycleResponse>(descriptor);
		}

		public Task<IlmGetLifecycleResponse> GetLifecycleAsync(Action<IlmGetLifecycleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmGetLifecycleRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmGetLifecycleRequestDescriptor, IlmGetLifecycleResponse>(descriptor);
		}

		public IlmGetStatusResponse GetStatus(IlmGetStatusRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmGetStatusRequest, IlmGetStatusResponse>(request);
		}

		public Task<IlmGetStatusResponse> GetStatusAsync(IlmGetStatusRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmGetStatusRequest, IlmGetStatusResponse>(request, cancellationToken);
		}

		public IlmGetStatusResponse GetStatus()
		{
			var descriptor = new IlmGetStatusRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<IlmGetStatusRequestDescriptor, IlmGetStatusResponse>(descriptor);
		}

		public IlmGetStatusResponse GetStatus(Action<IlmGetStatusRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmGetStatusRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmGetStatusRequestDescriptor, IlmGetStatusResponse>(descriptor);
		}

		public Task<IlmGetStatusResponse> GetStatusAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmGetStatusRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmGetStatusRequestDescriptor, IlmGetStatusResponse>(descriptor);
		}

		public Task<IlmGetStatusResponse> GetStatusAsync(Action<IlmGetStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmGetStatusRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmGetStatusRequestDescriptor, IlmGetStatusResponse>(descriptor);
		}

		public IlmMigrateToDataTiersResponse MigrateToDataTiers(IlmMigrateToDataTiersRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmMigrateToDataTiersRequest, IlmMigrateToDataTiersResponse>(request);
		}

		public Task<IlmMigrateToDataTiersResponse> MigrateToDataTiersAsync(IlmMigrateToDataTiersRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmMigrateToDataTiersRequest, IlmMigrateToDataTiersResponse>(request, cancellationToken);
		}

		public IlmMigrateToDataTiersResponse MigrateToDataTiers()
		{
			var descriptor = new IlmMigrateToDataTiersRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<IlmMigrateToDataTiersRequestDescriptor, IlmMigrateToDataTiersResponse>(descriptor);
		}

		public IlmMigrateToDataTiersResponse MigrateToDataTiers(Action<IlmMigrateToDataTiersRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmMigrateToDataTiersRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmMigrateToDataTiersRequestDescriptor, IlmMigrateToDataTiersResponse>(descriptor);
		}

		public Task<IlmMigrateToDataTiersResponse> MigrateToDataTiersAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMigrateToDataTiersRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMigrateToDataTiersRequestDescriptor, IlmMigrateToDataTiersResponse>(descriptor);
		}

		public Task<IlmMigrateToDataTiersResponse> MigrateToDataTiersAsync(Action<IlmMigrateToDataTiersRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMigrateToDataTiersRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMigrateToDataTiersRequestDescriptor, IlmMigrateToDataTiersResponse>(descriptor);
		}

		public IlmMoveToStepResponse MoveToStep(IlmMoveToStepRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmMoveToStepRequest, IlmMoveToStepResponse>(request);
		}

		public Task<IlmMoveToStepResponse> MoveToStepAsync(IlmMoveToStepRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmMoveToStepRequest, IlmMoveToStepResponse>(request, cancellationToken);
		}

		public IlmMoveToStepResponse MoveToStep(Elastic.Clients.Elasticsearch.IndexName index)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequest<IlmMoveToStepRequestDescriptor, IlmMoveToStepResponse>(descriptor);
		}

		public IlmMoveToStepResponse MoveToStep(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmMoveToStepRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmMoveToStepRequestDescriptor, IlmMoveToStepResponse>(descriptor);
		}

		public IlmMoveToStepResponse MoveToStep<TDocument>()
		{
			var descriptor = new IlmMoveToStepRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequest<IlmMoveToStepRequestDescriptor<TDocument>, IlmMoveToStepResponse>(descriptor);
		}

		public IlmMoveToStepResponse MoveToStep<TDocument>(Action<IlmMoveToStepRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmMoveToStepRequestDescriptor<TDocument>, IlmMoveToStepResponse>(descriptor);
		}

		public IlmMoveToStepResponse MoveToStep<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmMoveToStepRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmMoveToStepRequestDescriptor<TDocument>, IlmMoveToStepResponse>(descriptor);
		}

		public Task<IlmMoveToStepResponse> MoveToStepAsync(Elastic.Clients.Elasticsearch.IndexName index, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMoveToStepRequestDescriptor, IlmMoveToStepResponse>(descriptor);
		}

		public Task<IlmMoveToStepResponse> MoveToStepAsync(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmMoveToStepRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMoveToStepRequestDescriptor, IlmMoveToStepResponse>(descriptor);
		}

		public Task<IlmMoveToStepResponse> MoveToStepAsync<TDocument>(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMoveToStepRequestDescriptor<TDocument>, IlmMoveToStepResponse>(descriptor);
		}

		public Task<IlmMoveToStepResponse> MoveToStepAsync<TDocument>(Action<IlmMoveToStepRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMoveToStepRequestDescriptor<TDocument>, IlmMoveToStepResponse>(descriptor);
		}

		public Task<IlmMoveToStepResponse> MoveToStepAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmMoveToStepRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmMoveToStepRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmMoveToStepRequestDescriptor<TDocument>, IlmMoveToStepResponse>(descriptor);
		}

		public IlmPutLifecycleResponse PutLifecycle(IlmPutLifecycleRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmPutLifecycleRequest, IlmPutLifecycleResponse>(request);
		}

		public Task<IlmPutLifecycleResponse> PutLifecycleAsync(IlmPutLifecycleRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmPutLifecycleRequest, IlmPutLifecycleResponse>(request, cancellationToken);
		}

		public IlmPutLifecycleResponse PutLifecycle(Elastic.Clients.Elasticsearch.Name policy)
		{
			var descriptor = new IlmPutLifecycleRequestDescriptor(policy);
			descriptor.BeforeRequest();
			return DoRequest<IlmPutLifecycleRequestDescriptor, IlmPutLifecycleResponse>(descriptor);
		}

		public IlmPutLifecycleResponse PutLifecycle(Elastic.Clients.Elasticsearch.Name policy, Action<IlmPutLifecycleRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmPutLifecycleRequestDescriptor(policy);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmPutLifecycleRequestDescriptor, IlmPutLifecycleResponse>(descriptor);
		}

		public Task<IlmPutLifecycleResponse> PutLifecycleAsync(Elastic.Clients.Elasticsearch.Name policy, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmPutLifecycleRequestDescriptor(policy);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmPutLifecycleRequestDescriptor, IlmPutLifecycleResponse>(descriptor);
		}

		public Task<IlmPutLifecycleResponse> PutLifecycleAsync(Elastic.Clients.Elasticsearch.Name policy, Action<IlmPutLifecycleRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmPutLifecycleRequestDescriptor(policy);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmPutLifecycleRequestDescriptor, IlmPutLifecycleResponse>(descriptor);
		}

		public IlmRemovePolicyResponse RemovePolicy(IlmRemovePolicyRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmRemovePolicyRequest, IlmRemovePolicyResponse>(request);
		}

		public Task<IlmRemovePolicyResponse> RemovePolicyAsync(IlmRemovePolicyRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmRemovePolicyRequest, IlmRemovePolicyResponse>(request, cancellationToken);
		}

		public IlmRemovePolicyResponse RemovePolicy(Elastic.Clients.Elasticsearch.IndexName index)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequest<IlmRemovePolicyRequestDescriptor, IlmRemovePolicyResponse>(descriptor);
		}

		public IlmRemovePolicyResponse RemovePolicy(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRemovePolicyRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmRemovePolicyRequestDescriptor, IlmRemovePolicyResponse>(descriptor);
		}

		public IlmRemovePolicyResponse RemovePolicy<TDocument>()
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequest<IlmRemovePolicyRequestDescriptor<TDocument>, IlmRemovePolicyResponse>(descriptor);
		}

		public IlmRemovePolicyResponse RemovePolicy<TDocument>(Action<IlmRemovePolicyRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmRemovePolicyRequestDescriptor<TDocument>, IlmRemovePolicyResponse>(descriptor);
		}

		public IlmRemovePolicyResponse RemovePolicy<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRemovePolicyRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmRemovePolicyRequestDescriptor<TDocument>, IlmRemovePolicyResponse>(descriptor);
		}

		public Task<IlmRemovePolicyResponse> RemovePolicyAsync(Elastic.Clients.Elasticsearch.IndexName index, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRemovePolicyRequestDescriptor, IlmRemovePolicyResponse>(descriptor);
		}

		public Task<IlmRemovePolicyResponse> RemovePolicyAsync(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRemovePolicyRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRemovePolicyRequestDescriptor, IlmRemovePolicyResponse>(descriptor);
		}

		public Task<IlmRemovePolicyResponse> RemovePolicyAsync<TDocument>(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRemovePolicyRequestDescriptor<TDocument>, IlmRemovePolicyResponse>(descriptor);
		}

		public Task<IlmRemovePolicyResponse> RemovePolicyAsync<TDocument>(Action<IlmRemovePolicyRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRemovePolicyRequestDescriptor<TDocument>, IlmRemovePolicyResponse>(descriptor);
		}

		public Task<IlmRemovePolicyResponse> RemovePolicyAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRemovePolicyRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRemovePolicyRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRemovePolicyRequestDescriptor<TDocument>, IlmRemovePolicyResponse>(descriptor);
		}

		public IlmRetryResponse Retry(IlmRetryRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmRetryRequest, IlmRetryResponse>(request);
		}

		public Task<IlmRetryResponse> RetryAsync(IlmRetryRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmRetryRequest, IlmRetryResponse>(request, cancellationToken);
		}

		public IlmRetryResponse Retry(Elastic.Clients.Elasticsearch.IndexName index)
		{
			var descriptor = new IlmRetryRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequest<IlmRetryRequestDescriptor, IlmRetryResponse>(descriptor);
		}

		public IlmRetryResponse Retry(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRetryRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmRetryRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmRetryRequestDescriptor, IlmRetryResponse>(descriptor);
		}

		public IlmRetryResponse Retry<TDocument>()
		{
			var descriptor = new IlmRetryRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequest<IlmRetryRequestDescriptor<TDocument>, IlmRetryResponse>(descriptor);
		}

		public IlmRetryResponse Retry<TDocument>(Action<IlmRetryRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmRetryRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmRetryRequestDescriptor<TDocument>, IlmRetryResponse>(descriptor);
		}

		public IlmRetryResponse Retry<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRetryRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new IlmRetryRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmRetryRequestDescriptor<TDocument>, IlmRetryResponse>(descriptor);
		}

		public Task<IlmRetryResponse> RetryAsync(Elastic.Clients.Elasticsearch.IndexName index, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRetryRequestDescriptor(index);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRetryRequestDescriptor, IlmRetryResponse>(descriptor);
		}

		public Task<IlmRetryResponse> RetryAsync(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRetryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRetryRequestDescriptor(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRetryRequestDescriptor, IlmRetryResponse>(descriptor);
		}

		public Task<IlmRetryResponse> RetryAsync<TDocument>(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRetryRequestDescriptor<TDocument>(typeof(TDocument));
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRetryRequestDescriptor<TDocument>, IlmRetryResponse>(descriptor);
		}

		public Task<IlmRetryResponse> RetryAsync<TDocument>(Action<IlmRetryRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRetryRequestDescriptor<TDocument>(typeof(TDocument));
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRetryRequestDescriptor<TDocument>, IlmRetryResponse>(descriptor);
		}

		public Task<IlmRetryResponse> RetryAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Action<IlmRetryRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmRetryRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmRetryRequestDescriptor<TDocument>, IlmRetryResponse>(descriptor);
		}

		public IlmStartResponse Start(IlmStartRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmStartRequest, IlmStartResponse>(request);
		}

		public Task<IlmStartResponse> StartAsync(IlmStartRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmStartRequest, IlmStartResponse>(request, cancellationToken);
		}

		public IlmStartResponse Start()
		{
			var descriptor = new IlmStartRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<IlmStartRequestDescriptor, IlmStartResponse>(descriptor);
		}

		public IlmStartResponse Start(Action<IlmStartRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmStartRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmStartRequestDescriptor, IlmStartResponse>(descriptor);
		}

		public Task<IlmStartResponse> StartAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmStartRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmStartRequestDescriptor, IlmStartResponse>(descriptor);
		}

		public Task<IlmStartResponse> StartAsync(Action<IlmStartRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmStartRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmStartRequestDescriptor, IlmStartResponse>(descriptor);
		}

		public IlmStopResponse Stop(IlmStopRequest request)
		{
			request.BeforeRequest();
			return DoRequest<IlmStopRequest, IlmStopResponse>(request);
		}

		public Task<IlmStopResponse> StopAsync(IlmStopRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IlmStopRequest, IlmStopResponse>(request, cancellationToken);
		}

		public IlmStopResponse Stop()
		{
			var descriptor = new IlmStopRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<IlmStopRequestDescriptor, IlmStopResponse>(descriptor);
		}

		public IlmStopResponse Stop(Action<IlmStopRequestDescriptor> configureRequest)
		{
			var descriptor = new IlmStopRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<IlmStopRequestDescriptor, IlmStopResponse>(descriptor);
		}

		public Task<IlmStopResponse> StopAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmStopRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmStopRequestDescriptor, IlmStopResponse>(descriptor);
		}

		public Task<IlmStopResponse> StopAsync(Action<IlmStopRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new IlmStopRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<IlmStopRequestDescriptor, IlmStopResponse>(descriptor);
		}
	}
}