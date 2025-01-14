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
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public class SnapshotNamespace : NamespacedClientProxy
	{
		internal SnapshotNamespace(ElasticsearchClient client) : base(client)
		{
		}

		public CreateSnapshotResponse Create(CreateSnapshotRequest request)
		{
			request.BeforeRequest();
			return DoRequest<CreateSnapshotRequest, CreateSnapshotResponse>(request);
		}

		public Task<CreateSnapshotResponse> CreateAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<CreateSnapshotRequest, CreateSnapshotResponse>(request, cancellationToken);
		}

		public CreateSnapshotResponse Create(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot)
		{
			var descriptor = new CreateSnapshotRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequest<CreateSnapshotRequestDescriptor, CreateSnapshotResponse>(descriptor);
		}

		public CreateSnapshotResponse Create(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<CreateSnapshotRequestDescriptor> configureRequest)
		{
			var descriptor = new CreateSnapshotRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<CreateSnapshotRequestDescriptor, CreateSnapshotResponse>(descriptor);
		}

		public Task<CreateSnapshotResponse> CreateAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, CancellationToken cancellationToken = default)
		{
			var descriptor = new CreateSnapshotRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequestAsync<CreateSnapshotRequestDescriptor, CreateSnapshotResponse>(descriptor);
		}

		public Task<CreateSnapshotResponse> CreateAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<CreateSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new CreateSnapshotRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<CreateSnapshotRequestDescriptor, CreateSnapshotResponse>(descriptor);
		}

		public DeleteSnapshotResponse Delete(DeleteSnapshotRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteSnapshotRequest, DeleteSnapshotResponse>(request);
		}

		public Task<DeleteSnapshotResponse> DeleteAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteSnapshotRequest, DeleteSnapshotResponse>(request, cancellationToken);
		}

		public DeleteSnapshotResponse Delete(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot)
		{
			var descriptor = new DeleteSnapshotRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequest<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse>(descriptor);
		}

		public DeleteSnapshotResponse Delete(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<DeleteSnapshotRequestDescriptor> configureRequest)
		{
			var descriptor = new DeleteSnapshotRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse>(descriptor);
		}

		public Task<DeleteSnapshotResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteSnapshotRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse>(descriptor);
		}

		public Task<DeleteSnapshotResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<DeleteSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteSnapshotRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse>(descriptor);
		}

		public GetSnapshotResponse Get(GetSnapshotRequest request)
		{
			request.BeforeRequest();
			return DoRequest<GetSnapshotRequest, GetSnapshotResponse>(request);
		}

		public Task<GetSnapshotResponse> GetAsync(GetSnapshotRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<GetSnapshotRequest, GetSnapshotResponse>(request, cancellationToken);
		}

		public GetSnapshotResponse Get(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Names snapshot)
		{
			var descriptor = new GetSnapshotRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequest<GetSnapshotRequestDescriptor, GetSnapshotResponse>(descriptor);
		}

		public GetSnapshotResponse Get(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Names snapshot, Action<GetSnapshotRequestDescriptor> configureRequest)
		{
			var descriptor = new GetSnapshotRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<GetSnapshotRequestDescriptor, GetSnapshotResponse>(descriptor);
		}

		public Task<GetSnapshotResponse> GetAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Names snapshot, CancellationToken cancellationToken = default)
		{
			var descriptor = new GetSnapshotRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequestAsync<GetSnapshotRequestDescriptor, GetSnapshotResponse>(descriptor);
		}

		public Task<GetSnapshotResponse> GetAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Names snapshot, Action<GetSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new GetSnapshotRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<GetSnapshotRequestDescriptor, GetSnapshotResponse>(descriptor);
		}

		public SnapshotCleanupRepositoryResponse CleanupRepository(SnapshotCleanupRepositoryRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotCleanupRepositoryRequest, SnapshotCleanupRepositoryResponse>(request);
		}

		public Task<SnapshotCleanupRepositoryResponse> CleanupRepositoryAsync(SnapshotCleanupRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotCleanupRepositoryRequest, SnapshotCleanupRepositoryResponse>(request, cancellationToken);
		}

		public SnapshotCleanupRepositoryResponse CleanupRepository(Elastic.Clients.Elasticsearch.Name repository)
		{
			var descriptor = new SnapshotCleanupRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotCleanupRepositoryRequestDescriptor, SnapshotCleanupRepositoryResponse>(descriptor);
		}

		public SnapshotCleanupRepositoryResponse CleanupRepository(Elastic.Clients.Elasticsearch.Name repository, Action<SnapshotCleanupRepositoryRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotCleanupRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotCleanupRepositoryRequestDescriptor, SnapshotCleanupRepositoryResponse>(descriptor);
		}

		public Task<SnapshotCleanupRepositoryResponse> CleanupRepositoryAsync(Elastic.Clients.Elasticsearch.Name repository, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotCleanupRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotCleanupRepositoryRequestDescriptor, SnapshotCleanupRepositoryResponse>(descriptor);
		}

		public Task<SnapshotCleanupRepositoryResponse> CleanupRepositoryAsync(Elastic.Clients.Elasticsearch.Name repository, Action<SnapshotCleanupRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotCleanupRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotCleanupRepositoryRequestDescriptor, SnapshotCleanupRepositoryResponse>(descriptor);
		}

		public SnapshotCloneResponse Clone(SnapshotCloneRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotCloneRequest, SnapshotCloneResponse>(request);
		}

		public Task<SnapshotCloneResponse> CloneAsync(SnapshotCloneRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotCloneRequest, SnapshotCloneResponse>(request, cancellationToken);
		}

		public SnapshotCloneResponse Clone(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Elastic.Clients.Elasticsearch.Name target_snapshot)
		{
			var descriptor = new SnapshotCloneRequestDescriptor(repository, snapshot, target_snapshot);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotCloneRequestDescriptor, SnapshotCloneResponse>(descriptor);
		}

		public SnapshotCloneResponse Clone(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Elastic.Clients.Elasticsearch.Name target_snapshot, Action<SnapshotCloneRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotCloneRequestDescriptor(repository, snapshot, target_snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotCloneRequestDescriptor, SnapshotCloneResponse>(descriptor);
		}

		public Task<SnapshotCloneResponse> CloneAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Elastic.Clients.Elasticsearch.Name target_snapshot, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotCloneRequestDescriptor(repository, snapshot, target_snapshot);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotCloneRequestDescriptor, SnapshotCloneResponse>(descriptor);
		}

		public Task<SnapshotCloneResponse> CloneAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Elastic.Clients.Elasticsearch.Name target_snapshot, Action<SnapshotCloneRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotCloneRequestDescriptor(repository, snapshot, target_snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotCloneRequestDescriptor, SnapshotCloneResponse>(descriptor);
		}

		public SnapshotCreateRepositoryResponse CreateRepository(SnapshotCreateRepositoryRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotCreateRepositoryRequest, SnapshotCreateRepositoryResponse>(request);
		}

		public Task<SnapshotCreateRepositoryResponse> CreateRepositoryAsync(SnapshotCreateRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotCreateRepositoryRequest, SnapshotCreateRepositoryResponse>(request, cancellationToken);
		}

		public SnapshotCreateRepositoryResponse CreateRepository(Elastic.Clients.Elasticsearch.Name repository)
		{
			var descriptor = new SnapshotCreateRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotCreateRepositoryRequestDescriptor, SnapshotCreateRepositoryResponse>(descriptor);
		}

		public SnapshotCreateRepositoryResponse CreateRepository(Elastic.Clients.Elasticsearch.Name repository, Action<SnapshotCreateRepositoryRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotCreateRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotCreateRepositoryRequestDescriptor, SnapshotCreateRepositoryResponse>(descriptor);
		}

		public Task<SnapshotCreateRepositoryResponse> CreateRepositoryAsync(Elastic.Clients.Elasticsearch.Name repository, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotCreateRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotCreateRepositoryRequestDescriptor, SnapshotCreateRepositoryResponse>(descriptor);
		}

		public Task<SnapshotCreateRepositoryResponse> CreateRepositoryAsync(Elastic.Clients.Elasticsearch.Name repository, Action<SnapshotCreateRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotCreateRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotCreateRepositoryRequestDescriptor, SnapshotCreateRepositoryResponse>(descriptor);
		}

		public SnapshotDeleteRepositoryResponse DeleteRepository(SnapshotDeleteRepositoryRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotDeleteRepositoryRequest, SnapshotDeleteRepositoryResponse>(request);
		}

		public Task<SnapshotDeleteRepositoryResponse> DeleteRepositoryAsync(SnapshotDeleteRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotDeleteRepositoryRequest, SnapshotDeleteRepositoryResponse>(request, cancellationToken);
		}

		public SnapshotDeleteRepositoryResponse DeleteRepository(Elastic.Clients.Elasticsearch.Names repository)
		{
			var descriptor = new SnapshotDeleteRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotDeleteRepositoryRequestDescriptor, SnapshotDeleteRepositoryResponse>(descriptor);
		}

		public SnapshotDeleteRepositoryResponse DeleteRepository(Elastic.Clients.Elasticsearch.Names repository, Action<SnapshotDeleteRepositoryRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotDeleteRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotDeleteRepositoryRequestDescriptor, SnapshotDeleteRepositoryResponse>(descriptor);
		}

		public Task<SnapshotDeleteRepositoryResponse> DeleteRepositoryAsync(Elastic.Clients.Elasticsearch.Names repository, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotDeleteRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotDeleteRepositoryRequestDescriptor, SnapshotDeleteRepositoryResponse>(descriptor);
		}

		public Task<SnapshotDeleteRepositoryResponse> DeleteRepositoryAsync(Elastic.Clients.Elasticsearch.Names repository, Action<SnapshotDeleteRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotDeleteRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotDeleteRepositoryRequestDescriptor, SnapshotDeleteRepositoryResponse>(descriptor);
		}

		public SnapshotGetRepositoryResponse GetRepository(SnapshotGetRepositoryRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotGetRepositoryRequest, SnapshotGetRepositoryResponse>(request);
		}

		public Task<SnapshotGetRepositoryResponse> GetRepositoryAsync(SnapshotGetRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotGetRepositoryRequest, SnapshotGetRepositoryResponse>(request, cancellationToken);
		}

		public SnapshotGetRepositoryResponse GetRepository()
		{
			var descriptor = new SnapshotGetRepositoryRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<SnapshotGetRepositoryRequestDescriptor, SnapshotGetRepositoryResponse>(descriptor);
		}

		public SnapshotGetRepositoryResponse GetRepository(Action<SnapshotGetRepositoryRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotGetRepositoryRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotGetRepositoryRequestDescriptor, SnapshotGetRepositoryResponse>(descriptor);
		}

		public Task<SnapshotGetRepositoryResponse> GetRepositoryAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotGetRepositoryRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotGetRepositoryRequestDescriptor, SnapshotGetRepositoryResponse>(descriptor);
		}

		public Task<SnapshotGetRepositoryResponse> GetRepositoryAsync(Action<SnapshotGetRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotGetRepositoryRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotGetRepositoryRequestDescriptor, SnapshotGetRepositoryResponse>(descriptor);
		}

		public SnapshotRestoreResponse Restore(SnapshotRestoreRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotRestoreRequest, SnapshotRestoreResponse>(request);
		}

		public Task<SnapshotRestoreResponse> RestoreAsync(SnapshotRestoreRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotRestoreRequest, SnapshotRestoreResponse>(request, cancellationToken);
		}

		public SnapshotRestoreResponse Restore(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot)
		{
			var descriptor = new SnapshotRestoreRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotRestoreRequestDescriptor, SnapshotRestoreResponse>(descriptor);
		}

		public SnapshotRestoreResponse Restore(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<SnapshotRestoreRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotRestoreRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotRestoreRequestDescriptor, SnapshotRestoreResponse>(descriptor);
		}

		public SnapshotRestoreResponse Restore<TDocument>(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<SnapshotRestoreRequestDescriptor<TDocument>> configureRequest)
		{
			var descriptor = new SnapshotRestoreRequestDescriptor<TDocument>(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotRestoreRequestDescriptor<TDocument>, SnapshotRestoreResponse>(descriptor);
		}

		public Task<SnapshotRestoreResponse> RestoreAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotRestoreRequestDescriptor(repository, snapshot);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotRestoreRequestDescriptor, SnapshotRestoreResponse>(descriptor);
		}

		public Task<SnapshotRestoreResponse> RestoreAsync(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<SnapshotRestoreRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotRestoreRequestDescriptor(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotRestoreRequestDescriptor, SnapshotRestoreResponse>(descriptor);
		}

		public Task<SnapshotRestoreResponse> RestoreAsync<TDocument>(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot, Action<SnapshotRestoreRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotRestoreRequestDescriptor<TDocument>(repository, snapshot);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotRestoreRequestDescriptor<TDocument>, SnapshotRestoreResponse>(descriptor);
		}

		public SnapshotStatusResponse Status(SnapshotStatusRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotStatusRequest, SnapshotStatusResponse>(request);
		}

		public Task<SnapshotStatusResponse> StatusAsync(SnapshotStatusRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotStatusRequest, SnapshotStatusResponse>(request, cancellationToken);
		}

		public SnapshotStatusResponse Status()
		{
			var descriptor = new SnapshotStatusRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequest<SnapshotStatusRequestDescriptor, SnapshotStatusResponse>(descriptor);
		}

		public SnapshotStatusResponse Status(Action<SnapshotStatusRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotStatusRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotStatusRequestDescriptor, SnapshotStatusResponse>(descriptor);
		}

		public Task<SnapshotStatusResponse> StatusAsync(CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotStatusRequestDescriptor();
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse>(descriptor);
		}

		public Task<SnapshotStatusResponse> StatusAsync(Action<SnapshotStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotStatusRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse>(descriptor);
		}

		public SnapshotVerifyRepositoryResponse VerifyRepository(SnapshotVerifyRepositoryRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SnapshotVerifyRepositoryRequest, SnapshotVerifyRepositoryResponse>(request);
		}

		public Task<SnapshotVerifyRepositoryResponse> VerifyRepositoryAsync(SnapshotVerifyRepositoryRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SnapshotVerifyRepositoryRequest, SnapshotVerifyRepositoryResponse>(request, cancellationToken);
		}

		public SnapshotVerifyRepositoryResponse VerifyRepository(Elastic.Clients.Elasticsearch.Name repository)
		{
			var descriptor = new SnapshotVerifyRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotVerifyRepositoryRequestDescriptor, SnapshotVerifyRepositoryResponse>(descriptor);
		}

		public SnapshotVerifyRepositoryResponse VerifyRepository(Elastic.Clients.Elasticsearch.Name repository, Action<SnapshotVerifyRepositoryRequestDescriptor> configureRequest)
		{
			var descriptor = new SnapshotVerifyRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SnapshotVerifyRepositoryRequestDescriptor, SnapshotVerifyRepositoryResponse>(descriptor);
		}

		public Task<SnapshotVerifyRepositoryResponse> VerifyRepositoryAsync(Elastic.Clients.Elasticsearch.Name repository, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotVerifyRepositoryRequestDescriptor(repository);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotVerifyRepositoryRequestDescriptor, SnapshotVerifyRepositoryResponse>(descriptor);
		}

		public Task<SnapshotVerifyRepositoryResponse> VerifyRepositoryAsync(Elastic.Clients.Elasticsearch.Name repository, Action<SnapshotVerifyRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
		{
			var descriptor = new SnapshotVerifyRepositoryRequestDescriptor(repository);
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SnapshotVerifyRepositoryRequestDescriptor, SnapshotVerifyRepositoryResponse>(descriptor);
		}
	}
}