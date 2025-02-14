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
namespace Elastic.Clients.Elasticsearch.Ccr
{
	public sealed class CcrDeleteAutoFollowPatternRequestParameters : RequestParameters<CcrDeleteAutoFollowPatternRequestParameters>
	{
	}

	public partial class CcrDeleteAutoFollowPatternRequest : PlainRequestBase<CcrDeleteAutoFollowPatternRequestParameters>
	{
		public CcrDeleteAutoFollowPatternRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationDeleteAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public sealed partial class CcrDeleteAutoFollowPatternRequestDescriptor : RequestDescriptorBase<CcrDeleteAutoFollowPatternRequestDescriptor, CcrDeleteAutoFollowPatternRequestParameters>
	{
		internal CcrDeleteAutoFollowPatternRequestDescriptor(Action<CcrDeleteAutoFollowPatternRequestDescriptor> configure) => configure.Invoke(this);
		public CcrDeleteAutoFollowPatternRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal CcrDeleteAutoFollowPatternRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.CrossClusterReplicationDeleteAutoFollowPattern;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public CcrDeleteAutoFollowPatternRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
		{
			RouteValues.Required("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}