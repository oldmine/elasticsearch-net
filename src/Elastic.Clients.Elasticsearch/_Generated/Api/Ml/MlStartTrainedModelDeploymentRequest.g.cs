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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public class MlStartTrainedModelDeploymentRequestParameters : RequestParameters<MlStartTrainedModelDeploymentRequestParameters>
	{
		[JsonIgnore]
		public int? InferenceThreads { get => Q<int?>("inference_threads"); set => Q("inference_threads", value); }

		[JsonIgnore]
		public int? ModelThreads { get => Q<int?>("model_threads"); set => Q("model_threads", value); }

		[JsonIgnore]
		public int? QueueCapacity { get => Q<int?>("queue_capacity"); set => Q("queue_capacity", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Ml.DeploymentState? WaitFor { get => Q<Elastic.Clients.Elasticsearch.Ml.DeploymentState?>("wait_for"); set => Q("wait_for", value); }
	}

	public partial class MlStartTrainedModelDeploymentRequest : PlainRequestBase<MlStartTrainedModelDeploymentRequestParameters>
	{
		public MlStartTrainedModelDeploymentRequest(Elastic.Clients.Elasticsearch.Id model_id) : base(r => r.Required("model_id", model_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningStartTrainedModelDeployment;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public int? InferenceThreads { get => Q<int?>("inference_threads"); set => Q("inference_threads", value); }

		[JsonIgnore]
		public int? ModelThreads { get => Q<int?>("model_threads"); set => Q("model_threads", value); }

		[JsonIgnore]
		public int? QueueCapacity { get => Q<int?>("queue_capacity"); set => Q("queue_capacity", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Ml.DeploymentState? WaitFor { get => Q<Elastic.Clients.Elasticsearch.Ml.DeploymentState?>("wait_for"); set => Q("wait_for", value); }
	}

	public sealed partial class MlStartTrainedModelDeploymentRequestDescriptor : RequestDescriptorBase<MlStartTrainedModelDeploymentRequestDescriptor, MlStartTrainedModelDeploymentRequestParameters>
	{
		internal MlStartTrainedModelDeploymentRequestDescriptor(Action<MlStartTrainedModelDeploymentRequestDescriptor> configure) => configure.Invoke(this);
		public MlStartTrainedModelDeploymentRequestDescriptor(Elastic.Clients.Elasticsearch.Id model_id) : base(r => r.Required("model_id", model_id))
		{
		}

		internal MlStartTrainedModelDeploymentRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningStartTrainedModelDeployment;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public MlStartTrainedModelDeploymentRequestDescriptor InferenceThreads(int? inferenceThreads) => Qs("inference_threads", inferenceThreads);
		public MlStartTrainedModelDeploymentRequestDescriptor ModelThreads(int? modelThreads) => Qs("model_threads", modelThreads);
		public MlStartTrainedModelDeploymentRequestDescriptor QueueCapacity(int? queueCapacity) => Qs("queue_capacity", queueCapacity);
		public MlStartTrainedModelDeploymentRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public MlStartTrainedModelDeploymentRequestDescriptor WaitFor(Elastic.Clients.Elasticsearch.Ml.DeploymentState? waitFor) => Qs("wait_for", waitFor);
		public MlStartTrainedModelDeploymentRequestDescriptor ModelId(Elastic.Clients.Elasticsearch.Id model_id)
		{
			RouteValues.Required("model_id", model_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}