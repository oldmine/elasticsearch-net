﻿using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Newtonsoft.Json;

namespace Nest
{
	public partial interface IElasticClient
	{
		/// <summary>
		/// The /_search/template endpoint allows to use the mustache language to pre render search
		/// requests, before they are executed and fill existing templates with template parameters.
		/// </summary>
		ISearchResponse<T> SearchTemplate<T>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector)
			where T : class;

		/// <inheritdoc />
		ISearchResponse<TResult> SearchTemplate<T, TResult>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector)
			where T : class
			where TResult : class;

		/// <inheritdoc />
		ISearchResponse<T> SearchTemplate<T>(ISearchTemplateRequest request)
			where T : class;

		/// <inheritdoc />
		ISearchResponse<TResult> SearchTemplate<T, TResult>(ISearchTemplateRequest request)
			where T : class
			where TResult : class;

		/// <inheritdoc />
		Task<ISearchResponse<T>> SearchTemplateAsync<T>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector,
			CancellationToken cancellationToken = default(CancellationToken)
		)
			where T : class;

		/// <inheritdoc />
		Task<ISearchResponse<TResult>> SearchTemplateAsync<T, TResult>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector,
			CancellationToken cancellationToken = default(CancellationToken)
		)
			where T : class
			where TResult : class;

		/// <inheritdoc />
		Task<ISearchResponse<T>> SearchTemplateAsync<T>(ISearchTemplateRequest request,
			CancellationToken cancellationToken = default(CancellationToken)
		)
			where T : class;

		/// <inheritdoc />
		Task<ISearchResponse<TResult>> SearchTemplateAsync<T, TResult>(ISearchTemplateRequest request,
			CancellationToken cancellationToken = default(CancellationToken)
		)
			where T : class
			where TResult : class;
	}

	public partial class ElasticClient
	{
		public ISearchResponse<T> SearchTemplate<T>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector) where T : class =>
			SearchTemplate<T, T>(selector);

		public ISearchResponse<TResult> SearchTemplate<T, TResult>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector)
			where T : class
			where TResult : class =>
			SearchTemplate<T, TResult>(selector?.Invoke(new SearchTemplateDescriptor<T>()));

		public ISearchResponse<T> SearchTemplate<T>(ISearchTemplateRequest request) where T : class =>
			SearchTemplate<T, T>(request);

		public ISearchResponse<TResult> SearchTemplate<T, TResult>(ISearchTemplateRequest request)
			where T : class
			where TResult : class =>
			Dispatcher.Dispatch<ISearchTemplateRequest, SearchTemplateRequestParameters, SearchResponse<TResult>>(
				request,
				CreateSearchDeserializer<T, TResult>(request),
				LowLevelDispatch.SearchTemplateDispatch<SearchResponse<TResult>>
			);

		public Task<ISearchResponse<T>> SearchTemplateAsync<T>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector,
			CancellationToken cancellationToken = default(CancellationToken)
		) where T : class =>
			SearchTemplateAsync<T, T>(selector, cancellationToken);

		public Task<ISearchResponse<TResult>> SearchTemplateAsync<T, TResult>(Func<SearchTemplateDescriptor<T>, ISearchTemplateRequest> selector,
			CancellationToken cancellationToken = default(CancellationToken)
		)
			where T : class
			where TResult : class =>
			SearchTemplateAsync<T, TResult>(selector?.Invoke(new SearchTemplateDescriptor<T>()), cancellationToken);

		public Task<ISearchResponse<T>> SearchTemplateAsync<T>(ISearchTemplateRequest request,
			CancellationToken cancellationToken = default(CancellationToken)
		) where T : class =>
			SearchTemplateAsync<T, T>(request, cancellationToken);

		public Task<ISearchResponse<TResult>> SearchTemplateAsync<T, TResult>(ISearchTemplateRequest request,
			CancellationToken cancellationToken = default(CancellationToken)
		)
			where T : class
			where TResult : class =>
			Dispatcher.DispatchAsync<ISearchTemplateRequest, SearchTemplateRequestParameters, SearchResponse<TResult>, ISearchResponse<TResult>>(
				request,
				cancellationToken,
				CreateSearchDeserializer<T, TResult>(request),
				LowLevelDispatch.SearchTemplateDispatchAsync<SearchResponse<TResult>>
			);

		private SearchResponse<TResult> FieldsSearchDeserializer<T, TResult>(IApiCallDetails response, Stream stream, ISearchTemplateRequest d)
			where T : class
			where TResult : class
		{
			var converter = CreateCovariantSearchSelector<T, TResult>(d);
			var dict = response.Success
				? ConnectionSettings.StatefulSerializer(converter).Deserialize<SearchResponse<TResult>>(stream)
				: null;
			return dict;
		}

		private Func<IApiCallDetails, Stream, SearchResponse<TResult>> CreateSearchDeserializer<T, TResult>(ISearchTemplateRequest request)
			where T : class
			where TResult : class
		{
			Func<IApiCallDetails, Stream, SearchResponse<TResult>> responseCreator =
				(r, s) => FieldsSearchDeserializer<T, TResult>(r, s, request);
			return responseCreator;
		}

		private JsonConverter CreateCovariantSearchSelector<T, TResult>(ISearchTemplateRequest originalSearchDescriptor)
			where T : class
			where TResult : class
		{
			CovariantSearch.CloseOverAutomagicCovariantResultSelector(Infer, originalSearchDescriptor);
			return originalSearchDescriptor.TypeSelector == null ? null : new ConcreteTypeConverter<TResult>(originalSearchDescriptor.TypeSelector);
		}
	}
}