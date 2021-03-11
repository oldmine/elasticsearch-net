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
using System;
using System.Text.Json.Serialization;

namespace Nest
{
    public class DeleteLifecycleResponse : AcknowledgedResponseBase
    {
    }

    public class ExplainLifecycleResponse : ResponseBase
    {
    }

    public class GetLifecycleResponse : DictionaryResponseBase
    {
    }

    public class GetIlmStatusResponse : ResponseBase
    {
        [JsonPropertyName("operation_mode")]
        public LifecycleOperationMode OperationMode { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class MoveToStepResponse : AcknowledgedResponseBase
    {
    }

    public class PutLifecycleResponse : AcknowledgedResponseBase
    {
    }

    public class RemovePolicyResponse : ResponseBase
    {
        [JsonPropertyName("has_failures")]
        public bool HasFailures { get; 
#if NET5_0
            init;
#else
            internal set; 
#endif
        }
    }

    public class RetryIlmResponse : AcknowledgedResponseBase
    {
    }

    public class StartIlmResponse : AcknowledgedResponseBase
    {
    }

    public class StopIlmResponse : AcknowledgedResponseBase
    {
    }
}