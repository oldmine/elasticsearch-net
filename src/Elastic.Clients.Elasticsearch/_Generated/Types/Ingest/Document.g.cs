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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class Document
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public object Source { get; set; }
	}

	public sealed partial class DocumentDescriptor : SerializableDescriptorBase<DocumentDescriptor>
	{
		internal DocumentDescriptor(Action<DocumentDescriptor> configure) => configure.Invoke(this);
		public DocumentDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

		private object SourceValue { get; set; }

		public DocumentDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
		{
			IdValue = id;
			return Self;
		}

		public DocumentDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
		{
			IndexValue = index;
			return Self;
		}

		public DocumentDescriptor Source(object source)
		{
			SourceValue = source;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IdValue is not null)
			{
				writer.WritePropertyName("_id");
				JsonSerializer.Serialize(writer, IdValue, options);
			}

			if (IndexValue is not null)
			{
				writer.WritePropertyName("_index");
				JsonSerializer.Serialize(writer, IndexValue, options);
			}

			writer.WriteEndObject();
		}
	}
}