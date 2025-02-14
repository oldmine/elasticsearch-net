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
namespace Elastic.Clients.Elasticsearch.Slm
{
	public sealed class SlmDeleteLifecycleRequestParameters : RequestParameters<SlmDeleteLifecycleRequestParameters>
	{
	}

	public partial class SlmDeleteLifecycleRequest : PlainRequestBase<SlmDeleteLifecycleRequestParameters>
	{
		public SlmDeleteLifecycleRequest(Elastic.Clients.Elasticsearch.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementDeleteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public sealed partial class SlmDeleteLifecycleRequestDescriptor : RequestDescriptorBase<SlmDeleteLifecycleRequestDescriptor, SlmDeleteLifecycleRequestParameters>
	{
		internal SlmDeleteLifecycleRequestDescriptor(Action<SlmDeleteLifecycleRequestDescriptor> configure) => configure.Invoke(this);
		public SlmDeleteLifecycleRequestDescriptor(Elastic.Clients.Elasticsearch.Name policy_id) : base(r => r.Required("policy_id", policy_id))
		{
		}

		internal SlmDeleteLifecycleRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotLifecycleManagementDeleteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public SlmDeleteLifecycleRequestDescriptor PolicyId(Elastic.Clients.Elasticsearch.Name policy_id)
		{
			RouteValues.Required("policy_id", policy_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}