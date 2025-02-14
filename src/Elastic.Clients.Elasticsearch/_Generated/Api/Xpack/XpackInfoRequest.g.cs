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
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public sealed class XpackInfoRequestParameters : RequestParameters<XpackInfoRequestParameters>
	{
		[JsonIgnore]
		public IEnumerable<string>? Categories { get => Q<IEnumerable<string>?>("categories"); set => Q("categories", value); }

		[JsonIgnore]
		public bool? AcceptEnterprise { get => Q<bool?>("accept_enterprise"); set => Q("accept_enterprise", value); }
	}

	public partial class XpackInfoRequest : PlainRequestBase<XpackInfoRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.XpackInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public IEnumerable<string>? Categories { get => Q<IEnumerable<string>?>("categories"); set => Q("categories", value); }

		[JsonIgnore]
		public bool? AcceptEnterprise { get => Q<bool?>("accept_enterprise"); set => Q("accept_enterprise", value); }
	}

	public sealed partial class XpackInfoRequestDescriptor : RequestDescriptorBase<XpackInfoRequestDescriptor, XpackInfoRequestParameters>
	{
		internal XpackInfoRequestDescriptor(Action<XpackInfoRequestDescriptor> configure) => configure.Invoke(this);
		public XpackInfoRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.XpackInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public XpackInfoRequestDescriptor AcceptEnterprise(bool? acceptEnterprise = true) => Qs("accept_enterprise", acceptEnterprise);
		public XpackInfoRequestDescriptor Categories(IEnumerable<string>? categories) => Qs("categories", categories);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}