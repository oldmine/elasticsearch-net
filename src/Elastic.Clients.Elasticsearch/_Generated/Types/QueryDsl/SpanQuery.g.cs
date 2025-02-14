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
	public interface ISpanQueryVariant
	{
	}

	[JsonConverter(typeof(SpanQueryConverter))]
	public partial class SpanQuery
	{
		public SpanQuery(string variantName, ISpanQueryVariant variant)
		{
			if (variantName is null)
				throw new ArgumentNullException(nameof(variantName));
			if (variant is null)
				throw new ArgumentNullException(nameof(variant));
			if (string.IsNullOrWhiteSpace(variantName))
				throw new ArgumentException("Variant name must not be empty or whitespace.");
			VariantName = variantName;
			Variant = variant;
		}

		internal ISpanQueryVariant Variant { get; }

		internal string VariantName { get; }

		public static SpanQuery FieldMaskingSpan(Elastic.Clients.Elasticsearch.QueryDsl.SpanFieldMaskingQuery variant) => new SpanQuery("field_masking_span", variant);
		public static SpanQuery SpanContaining(Elastic.Clients.Elasticsearch.QueryDsl.SpanContainingQuery variant) => new SpanQuery("span_containing", variant);
		public static SpanQuery SpanFirst(Elastic.Clients.Elasticsearch.QueryDsl.SpanFirstQuery variant) => new SpanQuery("span_first", variant);
		public static SpanQuery SpanMulti(Elastic.Clients.Elasticsearch.QueryDsl.SpanMultiTermQuery variant) => new SpanQuery("span_multi", variant);
		public static SpanQuery SpanNear(Elastic.Clients.Elasticsearch.QueryDsl.SpanNearQuery variant) => new SpanQuery("span_near", variant);
		public static SpanQuery SpanNot(Elastic.Clients.Elasticsearch.QueryDsl.SpanNotQuery variant) => new SpanQuery("span_not", variant);
		public static SpanQuery SpanOr(Elastic.Clients.Elasticsearch.QueryDsl.SpanOrQuery variant) => new SpanQuery("span_or", variant);
		public static SpanQuery SpanTerm(Elastic.Clients.Elasticsearch.QueryDsl.SpanTermQuery variant) => new SpanQuery("span_term", variant);
		public static SpanQuery SpanWithin(Elastic.Clients.Elasticsearch.QueryDsl.SpanWithinQuery variant) => new SpanQuery("span_within", variant);
	}

	internal sealed class SpanQueryConverter : JsonConverter<SpanQuery>
	{
		public override SpanQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var readerCopy = reader;
			readerCopy.Read();
			if (readerCopy.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException();
			}

			var propertyName = readerCopy.GetString();
			if (propertyName == "field_masking_span")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanFieldMaskingQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_containing")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanContainingQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_first")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanFirstQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_multi")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanMultiTermQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_near")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanNearQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_not")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanNotQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_or")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanOrQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_term")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanTermQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			if (propertyName == "span_within")
			{
				var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanWithinQuery?>(ref reader, options);
				return new SpanQuery(propertyName, variant);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, SpanQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "field_masking_span":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanFieldMaskingQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanFieldMaskingQuery)value.Variant, options);
					break;
				case "span_containing":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanContainingQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanContainingQuery)value.Variant, options);
					break;
				case "span_first":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanFirstQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanFirstQuery)value.Variant, options);
					break;
				case "span_multi":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanMultiTermQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanMultiTermQuery)value.Variant, options);
					break;
				case "span_near":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanNearQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanNearQuery)value.Variant, options);
					break;
				case "span_not":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanNotQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanNotQuery)value.Variant, options);
					break;
				case "span_or":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanOrQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanOrQuery)value.Variant, options);
					break;
				case "span_term":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanTermQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanTermQuery)value.Variant, options);
					break;
				case "span_within":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.SpanWithinQuery>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.SpanWithinQuery)value.Variant, options);
					break;
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class SpanQueryDescriptor<TDocument> : SerializableDescriptorBase<SpanQueryDescriptor<TDocument>>
	{
		internal SpanQueryDescriptor(Action<SpanQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		public SpanQueryDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SpanQuery Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISpanQueryVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SpanQuery(variantName, variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void FieldMaskingSpan(SpanFieldMaskingQuery variant) => Set(variant, "field_masking_span");
		public void FieldMaskingSpan(Action<SpanFieldMaskingQueryDescriptor<TDocument>> configure) => Set(configure, "field_masking_span");
		public void SpanContaining(SpanContainingQuery variant) => Set(variant, "span_containing");
		public void SpanContaining(Action<SpanContainingQueryDescriptor<TDocument>> configure) => Set(configure, "span_containing");
		public void SpanFirst(SpanFirstQuery variant) => Set(variant, "span_first");
		public void SpanFirst(Action<SpanFirstQueryDescriptor<TDocument>> configure) => Set(configure, "span_first");
		public void SpanMulti(SpanMultiTermQuery variant) => Set(variant, "span_multi");
		public void SpanMulti(Action<SpanMultiTermQueryDescriptor<TDocument>> configure) => Set(configure, "span_multi");
		public void SpanNear(SpanNearQuery variant) => Set(variant, "span_near");
		public void SpanNear(Action<SpanNearQueryDescriptor<TDocument>> configure) => Set(configure, "span_near");
		public void SpanNot(SpanNotQuery variant) => Set(variant, "span_not");
		public void SpanNot(Action<SpanNotQueryDescriptor<TDocument>> configure) => Set(configure, "span_not");
		public void SpanOr(SpanOrQuery variant) => Set(variant, "span_or");
		public void SpanOr(Action<SpanOrQueryDescriptor<TDocument>> configure) => Set(configure, "span_or");
		public void SpanTerm(SpanTermQuery variant) => Set(variant, "span_term");
		public void SpanTerm(Action<SpanTermQueryDescriptor<TDocument>> configure) => Set(configure, "span_term");
		public void SpanWithin(SpanWithinQuery variant) => Set(variant, "span_within");
		public void SpanWithin(Action<SpanWithinQueryDescriptor<TDocument>> configure) => Set(configure, "span_within");
	}

	public sealed partial class SpanQueryDescriptor : SerializableDescriptorBase<SpanQueryDescriptor>
	{
		internal SpanQueryDescriptor(Action<SpanQueryDescriptor> configure) => configure.Invoke(this);
		public SpanQueryDescriptor() : base()
		{
		}

		internal bool ContainsVariant { get; private set; }

		internal string ContainedVariantName { get; private set; }

		internal SpanQuery Container { get; private set; }

		internal Descriptor Descriptor { get; private set; }

		internal Type DescriptorType { get; private set; }

		private void Set<T>(Action<T> descriptorAction, string variantName)
			where T : Descriptor, new()
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			ContainedVariantName = variantName;
			ContainsVariant = true;
			DescriptorType = typeof(T);
			var descriptor = new T();
			descriptorAction?.Invoke(descriptor);
			Descriptor = descriptor;
		}

		private void Set(ISpanQueryVariant variant, string variantName)
		{
			if (ContainsVariant)
				throw new Exception("TODO");
			Container = new SpanQuery(variantName, variant);
			ContainedVariantName = variantName;
			ContainsVariant = true;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			if (!ContainsVariant)
			{
				writer.WriteNullValue();
				return;
			}

			if (Container is not null)
			{
				JsonSerializer.Serialize(writer, Container, options);
				return;
			}

			writer.WriteStartObject();
			writer.WritePropertyName(ContainedVariantName);
			JsonSerializer.Serialize(writer, Descriptor, DescriptorType, options);
			writer.WriteEndObject();
		}

		public void FieldMaskingSpan(SpanFieldMaskingQuery variant) => Set(variant, "field_masking_span");
		public void FieldMaskingSpan(Action<SpanFieldMaskingQueryDescriptor> configure) => Set(configure, "field_masking_span");
		public void FieldMaskingSpan<TDocument>(Action<SpanFieldMaskingQueryDescriptor<TDocument>> configure) => Set(configure, "field_masking_span");
		public void SpanContaining(SpanContainingQuery variant) => Set(variant, "span_containing");
		public void SpanContaining(Action<SpanContainingQueryDescriptor> configure) => Set(configure, "span_containing");
		public void SpanContaining<TDocument>(Action<SpanContainingQueryDescriptor<TDocument>> configure) => Set(configure, "span_containing");
		public void SpanFirst(SpanFirstQuery variant) => Set(variant, "span_first");
		public void SpanFirst(Action<SpanFirstQueryDescriptor> configure) => Set(configure, "span_first");
		public void SpanFirst<TDocument>(Action<SpanFirstQueryDescriptor<TDocument>> configure) => Set(configure, "span_first");
		public void SpanMulti(SpanMultiTermQuery variant) => Set(variant, "span_multi");
		public void SpanMulti(Action<SpanMultiTermQueryDescriptor> configure) => Set(configure, "span_multi");
		public void SpanMulti<TDocument>(Action<SpanMultiTermQueryDescriptor<TDocument>> configure) => Set(configure, "span_multi");
		public void SpanNear(SpanNearQuery variant) => Set(variant, "span_near");
		public void SpanNear(Action<SpanNearQueryDescriptor> configure) => Set(configure, "span_near");
		public void SpanNear<TDocument>(Action<SpanNearQueryDescriptor<TDocument>> configure) => Set(configure, "span_near");
		public void SpanNot(SpanNotQuery variant) => Set(variant, "span_not");
		public void SpanNot(Action<SpanNotQueryDescriptor> configure) => Set(configure, "span_not");
		public void SpanNot<TDocument>(Action<SpanNotQueryDescriptor<TDocument>> configure) => Set(configure, "span_not");
		public void SpanOr(SpanOrQuery variant) => Set(variant, "span_or");
		public void SpanOr(Action<SpanOrQueryDescriptor> configure) => Set(configure, "span_or");
		public void SpanOr<TDocument>(Action<SpanOrQueryDescriptor<TDocument>> configure) => Set(configure, "span_or");
		public void SpanTerm(SpanTermQuery variant) => Set(variant, "span_term");
		public void SpanTerm(Action<SpanTermQueryDescriptor> configure) => Set(configure, "span_term");
		public void SpanTerm<TDocument>(Action<SpanTermQueryDescriptor<TDocument>> configure) => Set(configure, "span_term");
		public void SpanWithin(SpanWithinQuery variant) => Set(variant, "span_within");
		public void SpanWithin(Action<SpanWithinQueryDescriptor> configure) => Set(configure, "span_within");
		public void SpanWithin<TDocument>(Action<SpanWithinQueryDescriptor<TDocument>> configure) => Set(configure, "span_within");
	}
}