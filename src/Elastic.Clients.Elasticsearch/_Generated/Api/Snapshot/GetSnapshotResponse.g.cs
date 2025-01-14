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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public sealed partial class GetSnapshotResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("remaining")]
		public int Remaining { get; init; }

		[JsonInclude]
		[JsonPropertyName("responses")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Snapshot.SnapshotResponseItem>? Responses { get; init; }

		[JsonInclude]
		[JsonPropertyName("snapshots")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Snapshot.SnapshotInfo>? Snapshots { get; init; }

		[JsonInclude]
		[JsonPropertyName("total")]
		public int Total { get; init; }
	}
}