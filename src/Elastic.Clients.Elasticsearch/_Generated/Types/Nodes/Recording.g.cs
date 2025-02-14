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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class Recording
	{
		[JsonInclude]
		[JsonPropertyName("cumulative_execution_count")]
		public long? CumulativeExecutionCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("cumulative_execution_time")]
		public Elastic.Clients.Elasticsearch.Duration? CumulativeExecutionTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("cumulative_execution_time_millis")]
		public long? CumulativeExecutionTimeMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}
}