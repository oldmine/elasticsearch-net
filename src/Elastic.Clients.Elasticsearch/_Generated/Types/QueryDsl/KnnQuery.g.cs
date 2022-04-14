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
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class KnnQuery : QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string IQueryContainerVariant.QueryContainerVariantName => "knn";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("num_candidates")]
		public int NumCandidates { get; set; }

		[JsonInclude]
		[JsonPropertyName("query_vector")]
		public IEnumerable<double> QueryVector { get; set; }
	}

	public sealed partial class KnnQueryDescriptor<TDocument> : DescriptorBase<KnnQueryDescriptor<TDocument>>
	{
		internal KnnQueryDescriptor(Action<KnnQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public KnnQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private int NumCandidatesValue { get; set; }

		private IEnumerable<double> QueryVectorValue { get; set; }

		public KnnQueryDescriptor<TDocument> QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> NumCandidates(int numCandidates)
		{
			NumCandidatesValue = numCandidates;
			return Self;
		}

		public KnnQueryDescriptor<TDocument> QueryVector(IEnumerable<double> queryVector)
		{
			QueryVectorValue = queryVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("num_candidates");
			writer.WriteNumberValue(NumCandidatesValue);
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
			writer.WriteEndObject();
		}
	}

	public sealed partial class KnnQueryDescriptor : DescriptorBase<KnnQueryDescriptor>
	{
		internal KnnQueryDescriptor(Action<KnnQueryDescriptor> configure) => configure.Invoke(this);
		public KnnQueryDescriptor() : base()
		{
		}

		private string? QueryNameValue { get; set; }

		private float? BoostValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

		private int NumCandidatesValue { get; set; }

		private IEnumerable<double> QueryVectorValue { get; set; }

		public KnnQueryDescriptor QueryName(string? queryName)
		{
			QueryNameValue = queryName;
			return Self;
		}

		public KnnQueryDescriptor Boost(float? boost)
		{
			BoostValue = boost;
			return Self;
		}

		public KnnQueryDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public KnnQueryDescriptor NumCandidates(int numCandidates)
		{
			NumCandidatesValue = numCandidates;
			return Self;
		}

		public KnnQueryDescriptor QueryVector(IEnumerable<double> queryVector)
		{
			QueryVectorValue = queryVector;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			writer.WritePropertyName("num_candidates");
			writer.WriteNumberValue(NumCandidatesValue);
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
			writer.WriteEndObject();
		}
	}
}