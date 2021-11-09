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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public class ClusterPendingTasksRequestParameters : RequestParameters<ClusterPendingTasksRequestParameters>
	{
		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	public partial class ClusterPendingTasksRequest : PlainRequestBase<ClusterPendingTasksRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Time? MasterTimeout { get => Q<Time?>("master_timeout"); set => Q("master_timeout", value); }
	}

	[JsonConverter(typeof(ClusterPendingTasksRequestDescriptorConverter))]
	public sealed partial class ClusterPendingTasksRequestDescriptor : RequestDescriptorBase<ClusterPendingTasksRequestDescriptor, ClusterPendingTasksRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public ClusterPendingTasksRequestDescriptor Local(bool? local) => Qs("local", local);
		public ClusterPendingTasksRequestDescriptor MasterTimeout(Time? masterTimeout) => Qs("master_timeout", masterTimeout);
	}

	internal sealed class ClusterPendingTasksRequestDescriptorConverter : JsonConverter<ClusterPendingTasksRequestDescriptor>
	{
		public override ClusterPendingTasksRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, ClusterPendingTasksRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}