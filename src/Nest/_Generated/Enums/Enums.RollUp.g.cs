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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Runtime.Serialization;

#nullable restore
namespace Nest
{
	public enum IndexingJobState
	{
		[EnumMember(Value = "stopping")]
		Stopping,
		[EnumMember(Value = "stopped")]
		Stopped,
		[EnumMember(Value = "started")]
		Started,
		[EnumMember(Value = "indexing")]
		Indexing,
		[EnumMember(Value = "aborting")]
		Aborting
	}

	public enum Metric
	{
		[EnumMember(Value = "value_count")]
		ValueCount,
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "avg")]
		Avg
	}
}