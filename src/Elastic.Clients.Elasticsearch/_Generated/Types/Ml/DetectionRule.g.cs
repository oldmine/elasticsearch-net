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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class DetectionRule
	{
		[JsonInclude]
		[JsonPropertyName("actions")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.RuleAction>? Actions { get; set; }

		[JsonInclude]
		[JsonPropertyName("conditions")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.RuleCondition>? Conditions { get; set; }

		[JsonInclude]
		[JsonPropertyName("scope")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Ml.FilterRef>? Scope { get; set; }
	}

	public sealed partial class DetectionRuleDescriptor : DescriptorBase<DetectionRuleDescriptor>
	{
		internal DetectionRuleDescriptor(Action<DetectionRuleDescriptor> configure) => configure.Invoke(this);
		public DetectionRuleDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.RuleAction>? ActionsValue { get; set; }

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.RuleCondition>? ConditionsValue { get; set; }

		private Dictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Ml.FilterRef>? ScopeValue { get; set; }

		public DetectionRuleDescriptor Actions(IEnumerable<Elastic.Clients.Elasticsearch.Ml.RuleAction>? actions)
		{
			ActionsValue = actions;
			return Self;
		}

		public DetectionRuleDescriptor Conditions(IEnumerable<Elastic.Clients.Elasticsearch.Ml.RuleCondition>? conditions)
		{
			ConditionsValue = conditions;
			return Self;
		}

		public DetectionRuleDescriptor Scope(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Ml.FilterRef>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Ml.FilterRef>> selector)
		{
			ScopeValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, Elastic.Clients.Elasticsearch.Ml.FilterRef>());
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ActionsValue is not null)
			{
				writer.WritePropertyName("actions");
				JsonSerializer.Serialize(writer, ActionsValue, options);
			}

			if (ConditionsValue is not null)
			{
				writer.WritePropertyName("conditions");
				JsonSerializer.Serialize(writer, ConditionsValue, options);
			}

			if (ScopeValue is not null)
			{
				writer.WritePropertyName("scope");
				JsonSerializer.Serialize(writer, ScopeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}