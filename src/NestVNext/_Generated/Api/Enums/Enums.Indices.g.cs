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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System.Runtime.Serialization;

namespace Nest
{
    public enum ShardRoutingState
    {
        [EnumMember(Value = "UNASSIGNED")]
        Unassigned,
        [EnumMember(Value = "INITIALIZING")]
        Initializing,
        [EnumMember(Value = "STARTED")]
        Started,
        [EnumMember(Value = "RELOCATING")]
        Relocating
    }

    public enum ShardStoreAllocation
    {
        [EnumMember(Value = "primary")]
        Primary,
        [EnumMember(Value = "replica")]
        Replica,
        [EnumMember(Value = "unused")]
        Unused
    }
}