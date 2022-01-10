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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class TestPopulation
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }
	}

	public sealed partial class TestPopulationDescriptor<TDocument> : DescriptorBase<TestPopulationDescriptor<TDocument>>
	{
		public TestPopulationDescriptor()
		{
		}

		internal TestPopulationDescriptor(Action<TestPopulationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; private set; }

		internal ScriptBase? ScriptValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; private set; }

		internal ScriptDescriptor ScriptDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; private set; }

		internal Action<ScriptDescriptor> ScriptDescriptorAction { get; private set; }

		public TestPopulationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public TestPopulationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public TestPopulationDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			return Assign(filter, (a, v) => a.FilterValue = v);
		}

		public TestPopulationDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FilterDescriptor = v);
		}

		public TestPopulationDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.FilterDescriptorAction = v);
		}

		public TestPopulationDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			return Assign(script, (a, v) => a.ScriptValue = v);
		}

		public TestPopulationDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ScriptDescriptor = v);
		}

		public TestPopulationDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.ScriptDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
		}
	}
}