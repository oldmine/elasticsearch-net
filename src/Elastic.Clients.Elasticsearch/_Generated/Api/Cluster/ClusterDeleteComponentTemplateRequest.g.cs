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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public sealed class ClusterDeleteComponentTemplateRequestParameters : RequestParameters<ClusterDeleteComponentTemplateRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public partial class ClusterDeleteComponentTemplateRequest : PlainRequestBase<ClusterDeleteComponentTemplateRequestParameters>
	{
		public ClusterDeleteComponentTemplateRequest(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class ClusterDeleteComponentTemplateRequestDescriptor : RequestDescriptorBase<ClusterDeleteComponentTemplateRequestDescriptor, ClusterDeleteComponentTemplateRequestParameters>
	{
		internal ClusterDeleteComponentTemplateRequestDescriptor(Action<ClusterDeleteComponentTemplateRequestDescriptor> configure) => configure.Invoke(this);
		public ClusterDeleteComponentTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Names name) : base(r => r.Required("name", name))
		{
		}

		internal ClusterDeleteComponentTemplateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public ClusterDeleteComponentTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterDeleteComponentTemplateRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Duration? timeout) => Qs("timeout", timeout);
		public ClusterDeleteComponentTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}