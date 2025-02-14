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
	public sealed class MlValidateRequestParameters : RequestParameters<MlValidateRequestParameters>
	{
	}

	public partial class MlValidateRequest : PlainRequestBase<MlValidateRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningValidate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("job_id")]
		public Elastic.Clients.Elasticsearch.Id? JobId { get; set; }

		[JsonInclude]
		[JsonPropertyName("analysis_config")]
		public Elastic.Clients.Elasticsearch.Ml.AnalysisConfig? AnalysisConfig { get; set; }

		[JsonInclude]
		[JsonPropertyName("analysis_limits")]
		public Elastic.Clients.Elasticsearch.Ml.AnalysisLimits? AnalysisLimits { get; set; }

		[JsonInclude]
		[JsonPropertyName("data_description")]
		public Elastic.Clients.Elasticsearch.Ml.DataDescription? DataDescription { get; set; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_plot")]
		public Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? ModelPlot { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_snapshot_id")]
		public Elastic.Clients.Elasticsearch.Id? ModelSnapshotId { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_snapshot_retention_days")]
		public long? ModelSnapshotRetentionDays { get; set; }

		[JsonInclude]
		[JsonPropertyName("results_index_name")]
		public Elastic.Clients.Elasticsearch.IndexName? ResultsIndexName { get; set; }
	}

	public sealed partial class MlValidateRequestDescriptor<TDocument> : RequestDescriptorBase<MlValidateRequestDescriptor<TDocument>, MlValidateRequestParameters>
	{
		internal MlValidateRequestDescriptor(Action<MlValidateRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public MlValidateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningValidate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private Elastic.Clients.Elasticsearch.Ml.AnalysisConfig? AnalysisConfigValue { get; set; }

		private AnalysisConfigDescriptor<TDocument> AnalysisConfigDescriptor { get; set; }

		private Action<AnalysisConfigDescriptor<TDocument>> AnalysisConfigDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataDescription? DataDescriptionValue { get; set; }

		private DataDescriptionDescriptor<TDocument> DataDescriptionDescriptor { get; set; }

		private Action<DataDescriptionDescriptor<TDocument>> DataDescriptionDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? ModelPlotValue { get; set; }

		private ModelPlotConfigDescriptor<TDocument> ModelPlotDescriptor { get; set; }

		private Action<ModelPlotConfigDescriptor<TDocument>> ModelPlotDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.AnalysisLimits? AnalysisLimitsValue { get; set; }

		private AnalysisLimitsDescriptor AnalysisLimitsDescriptor { get; set; }

		private Action<AnalysisLimitsDescriptor> AnalysisLimitsDescriptorAction { get; set; }

		private string? DescriptionValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id? JobIdValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id? ModelSnapshotIdValue { get; set; }

		private long? ModelSnapshotRetentionDaysValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName? ResultsIndexNameValue { get; set; }

		public MlValidateRequestDescriptor<TDocument> AnalysisConfig(Elastic.Clients.Elasticsearch.Ml.AnalysisConfig? analysisConfig)
		{
			AnalysisConfigDescriptor = null;
			AnalysisConfigDescriptorAction = null;
			AnalysisConfigValue = analysisConfig;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> AnalysisConfig(AnalysisConfigDescriptor<TDocument> descriptor)
		{
			AnalysisConfigValue = null;
			AnalysisConfigDescriptorAction = null;
			AnalysisConfigDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> AnalysisConfig(Action<AnalysisConfigDescriptor<TDocument>> configure)
		{
			AnalysisConfigValue = null;
			AnalysisConfigDescriptor = null;
			AnalysisConfigDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> DataDescription(Elastic.Clients.Elasticsearch.Ml.DataDescription? dataDescription)
		{
			DataDescriptionDescriptor = null;
			DataDescriptionDescriptorAction = null;
			DataDescriptionValue = dataDescription;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> DataDescription(DataDescriptionDescriptor<TDocument> descriptor)
		{
			DataDescriptionValue = null;
			DataDescriptionDescriptorAction = null;
			DataDescriptionDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> DataDescription(Action<DataDescriptionDescriptor<TDocument>> configure)
		{
			DataDescriptionValue = null;
			DataDescriptionDescriptor = null;
			DataDescriptionDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> ModelPlot(Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? modelPlot)
		{
			ModelPlotDescriptor = null;
			ModelPlotDescriptorAction = null;
			ModelPlotValue = modelPlot;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> ModelPlot(ModelPlotConfigDescriptor<TDocument> descriptor)
		{
			ModelPlotValue = null;
			ModelPlotDescriptorAction = null;
			ModelPlotDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> ModelPlot(Action<ModelPlotConfigDescriptor<TDocument>> configure)
		{
			ModelPlotValue = null;
			ModelPlotDescriptor = null;
			ModelPlotDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> AnalysisLimits(Elastic.Clients.Elasticsearch.Ml.AnalysisLimits? analysisLimits)
		{
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsValue = analysisLimits;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> AnalysisLimits(AnalysisLimitsDescriptor descriptor)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> AnalysisLimits(Action<AnalysisLimitsDescriptor> configure)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> JobId(Elastic.Clients.Elasticsearch.Id? jobId)
		{
			JobIdValue = jobId;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> ModelSnapshotId(Elastic.Clients.Elasticsearch.Id? modelSnapshotId)
		{
			ModelSnapshotIdValue = modelSnapshotId;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> ModelSnapshotRetentionDays(long? modelSnapshotRetentionDays)
		{
			ModelSnapshotRetentionDaysValue = modelSnapshotRetentionDays;
			return Self;
		}

		public MlValidateRequestDescriptor<TDocument> ResultsIndexName(Elastic.Clients.Elasticsearch.IndexName? resultsIndexName)
		{
			ResultsIndexNameValue = resultsIndexName;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AnalysisConfigDescriptor is not null)
			{
				writer.WritePropertyName("analysis_config");
				JsonSerializer.Serialize(writer, AnalysisConfigDescriptor, options);
			}
			else if (AnalysisConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis_config");
				JsonSerializer.Serialize(writer, new AnalysisConfigDescriptor<TDocument>(AnalysisConfigDescriptorAction), options);
			}
			else if (AnalysisConfigValue is not null)
			{
				writer.WritePropertyName("analysis_config");
				JsonSerializer.Serialize(writer, AnalysisConfigValue, options);
			}

			if (DataDescriptionDescriptor is not null)
			{
				writer.WritePropertyName("data_description");
				JsonSerializer.Serialize(writer, DataDescriptionDescriptor, options);
			}
			else if (DataDescriptionDescriptorAction is not null)
			{
				writer.WritePropertyName("data_description");
				JsonSerializer.Serialize(writer, new DataDescriptionDescriptor<TDocument>(DataDescriptionDescriptorAction), options);
			}
			else if (DataDescriptionValue is not null)
			{
				writer.WritePropertyName("data_description");
				JsonSerializer.Serialize(writer, DataDescriptionValue, options);
			}

			if (ModelPlotDescriptor is not null)
			{
				writer.WritePropertyName("model_plot");
				JsonSerializer.Serialize(writer, ModelPlotDescriptor, options);
			}
			else if (ModelPlotDescriptorAction is not null)
			{
				writer.WritePropertyName("model_plot");
				JsonSerializer.Serialize(writer, new ModelPlotConfigDescriptor<TDocument>(ModelPlotDescriptorAction), options);
			}
			else if (ModelPlotValue is not null)
			{
				writer.WritePropertyName("model_plot");
				JsonSerializer.Serialize(writer, ModelPlotValue, options);
			}

			if (AnalysisLimitsDescriptor is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsDescriptor, options);
			}
			else if (AnalysisLimitsDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, new AnalysisLimitsDescriptor(AnalysisLimitsDescriptorAction), options);
			}
			else if (AnalysisLimitsValue is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (JobIdValue is not null)
			{
				writer.WritePropertyName("job_id");
				JsonSerializer.Serialize(writer, JobIdValue, options);
			}

			if (ModelSnapshotIdValue is not null)
			{
				writer.WritePropertyName("model_snapshot_id");
				JsonSerializer.Serialize(writer, ModelSnapshotIdValue, options);
			}

			if (ModelSnapshotRetentionDaysValue.HasValue)
			{
				writer.WritePropertyName("model_snapshot_retention_days");
				writer.WriteNumberValue(ModelSnapshotRetentionDaysValue.Value);
			}

			if (ResultsIndexNameValue is not null)
			{
				writer.WritePropertyName("results_index_name");
				JsonSerializer.Serialize(writer, ResultsIndexNameValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class MlValidateRequestDescriptor : RequestDescriptorBase<MlValidateRequestDescriptor, MlValidateRequestParameters>
	{
		internal MlValidateRequestDescriptor(Action<MlValidateRequestDescriptor> configure) => configure.Invoke(this);
		public MlValidateRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningValidate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		private Elastic.Clients.Elasticsearch.Ml.AnalysisConfig? AnalysisConfigValue { get; set; }

		private AnalysisConfigDescriptor AnalysisConfigDescriptor { get; set; }

		private Action<AnalysisConfigDescriptor> AnalysisConfigDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.DataDescription? DataDescriptionValue { get; set; }

		private DataDescriptionDescriptor DataDescriptionDescriptor { get; set; }

		private Action<DataDescriptionDescriptor> DataDescriptionDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? ModelPlotValue { get; set; }

		private ModelPlotConfigDescriptor ModelPlotDescriptor { get; set; }

		private Action<ModelPlotConfigDescriptor> ModelPlotDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Ml.AnalysisLimits? AnalysisLimitsValue { get; set; }

		private AnalysisLimitsDescriptor AnalysisLimitsDescriptor { get; set; }

		private Action<AnalysisLimitsDescriptor> AnalysisLimitsDescriptorAction { get; set; }

		private string? DescriptionValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id? JobIdValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id? ModelSnapshotIdValue { get; set; }

		private long? ModelSnapshotRetentionDaysValue { get; set; }

		private Elastic.Clients.Elasticsearch.IndexName? ResultsIndexNameValue { get; set; }

		public MlValidateRequestDescriptor AnalysisConfig(Elastic.Clients.Elasticsearch.Ml.AnalysisConfig? analysisConfig)
		{
			AnalysisConfigDescriptor = null;
			AnalysisConfigDescriptorAction = null;
			AnalysisConfigValue = analysisConfig;
			return Self;
		}

		public MlValidateRequestDescriptor AnalysisConfig(AnalysisConfigDescriptor descriptor)
		{
			AnalysisConfigValue = null;
			AnalysisConfigDescriptorAction = null;
			AnalysisConfigDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor AnalysisConfig(Action<AnalysisConfigDescriptor> configure)
		{
			AnalysisConfigValue = null;
			AnalysisConfigDescriptor = null;
			AnalysisConfigDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor DataDescription(Elastic.Clients.Elasticsearch.Ml.DataDescription? dataDescription)
		{
			DataDescriptionDescriptor = null;
			DataDescriptionDescriptorAction = null;
			DataDescriptionValue = dataDescription;
			return Self;
		}

		public MlValidateRequestDescriptor DataDescription(DataDescriptionDescriptor descriptor)
		{
			DataDescriptionValue = null;
			DataDescriptionDescriptorAction = null;
			DataDescriptionDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor DataDescription(Action<DataDescriptionDescriptor> configure)
		{
			DataDescriptionValue = null;
			DataDescriptionDescriptor = null;
			DataDescriptionDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor ModelPlot(Elastic.Clients.Elasticsearch.Ml.ModelPlotConfig? modelPlot)
		{
			ModelPlotDescriptor = null;
			ModelPlotDescriptorAction = null;
			ModelPlotValue = modelPlot;
			return Self;
		}

		public MlValidateRequestDescriptor ModelPlot(ModelPlotConfigDescriptor descriptor)
		{
			ModelPlotValue = null;
			ModelPlotDescriptorAction = null;
			ModelPlotDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor ModelPlot(Action<ModelPlotConfigDescriptor> configure)
		{
			ModelPlotValue = null;
			ModelPlotDescriptor = null;
			ModelPlotDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor AnalysisLimits(Elastic.Clients.Elasticsearch.Ml.AnalysisLimits? analysisLimits)
		{
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsValue = analysisLimits;
			return Self;
		}

		public MlValidateRequestDescriptor AnalysisLimits(AnalysisLimitsDescriptor descriptor)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptorAction = null;
			AnalysisLimitsDescriptor = descriptor;
			return Self;
		}

		public MlValidateRequestDescriptor AnalysisLimits(Action<AnalysisLimitsDescriptor> configure)
		{
			AnalysisLimitsValue = null;
			AnalysisLimitsDescriptor = null;
			AnalysisLimitsDescriptorAction = configure;
			return Self;
		}

		public MlValidateRequestDescriptor Description(string? description)
		{
			DescriptionValue = description;
			return Self;
		}

		public MlValidateRequestDescriptor JobId(Elastic.Clients.Elasticsearch.Id? jobId)
		{
			JobIdValue = jobId;
			return Self;
		}

		public MlValidateRequestDescriptor ModelSnapshotId(Elastic.Clients.Elasticsearch.Id? modelSnapshotId)
		{
			ModelSnapshotIdValue = modelSnapshotId;
			return Self;
		}

		public MlValidateRequestDescriptor ModelSnapshotRetentionDays(long? modelSnapshotRetentionDays)
		{
			ModelSnapshotRetentionDaysValue = modelSnapshotRetentionDays;
			return Self;
		}

		public MlValidateRequestDescriptor ResultsIndexName(Elastic.Clients.Elasticsearch.IndexName? resultsIndexName)
		{
			ResultsIndexNameValue = resultsIndexName;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AnalysisConfigDescriptor is not null)
			{
				writer.WritePropertyName("analysis_config");
				JsonSerializer.Serialize(writer, AnalysisConfigDescriptor, options);
			}
			else if (AnalysisConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis_config");
				JsonSerializer.Serialize(writer, new AnalysisConfigDescriptor(AnalysisConfigDescriptorAction), options);
			}
			else if (AnalysisConfigValue is not null)
			{
				writer.WritePropertyName("analysis_config");
				JsonSerializer.Serialize(writer, AnalysisConfigValue, options);
			}

			if (DataDescriptionDescriptor is not null)
			{
				writer.WritePropertyName("data_description");
				JsonSerializer.Serialize(writer, DataDescriptionDescriptor, options);
			}
			else if (DataDescriptionDescriptorAction is not null)
			{
				writer.WritePropertyName("data_description");
				JsonSerializer.Serialize(writer, new DataDescriptionDescriptor(DataDescriptionDescriptorAction), options);
			}
			else if (DataDescriptionValue is not null)
			{
				writer.WritePropertyName("data_description");
				JsonSerializer.Serialize(writer, DataDescriptionValue, options);
			}

			if (ModelPlotDescriptor is not null)
			{
				writer.WritePropertyName("model_plot");
				JsonSerializer.Serialize(writer, ModelPlotDescriptor, options);
			}
			else if (ModelPlotDescriptorAction is not null)
			{
				writer.WritePropertyName("model_plot");
				JsonSerializer.Serialize(writer, new ModelPlotConfigDescriptor(ModelPlotDescriptorAction), options);
			}
			else if (ModelPlotValue is not null)
			{
				writer.WritePropertyName("model_plot");
				JsonSerializer.Serialize(writer, ModelPlotValue, options);
			}

			if (AnalysisLimitsDescriptor is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsDescriptor, options);
			}
			else if (AnalysisLimitsDescriptorAction is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, new AnalysisLimitsDescriptor(AnalysisLimitsDescriptorAction), options);
			}
			else if (AnalysisLimitsValue is not null)
			{
				writer.WritePropertyName("analysis_limits");
				JsonSerializer.Serialize(writer, AnalysisLimitsValue, options);
			}

			if (!string.IsNullOrEmpty(DescriptionValue))
			{
				writer.WritePropertyName("description");
				writer.WriteStringValue(DescriptionValue);
			}

			if (JobIdValue is not null)
			{
				writer.WritePropertyName("job_id");
				JsonSerializer.Serialize(writer, JobIdValue, options);
			}

			if (ModelSnapshotIdValue is not null)
			{
				writer.WritePropertyName("model_snapshot_id");
				JsonSerializer.Serialize(writer, ModelSnapshotIdValue, options);
			}

			if (ModelSnapshotRetentionDaysValue.HasValue)
			{
				writer.WritePropertyName("model_snapshot_retention_days");
				writer.WriteNumberValue(ModelSnapshotRetentionDaysValue.Value);
			}

			if (ResultsIndexNameValue is not null)
			{
				writer.WritePropertyName("results_index_name");
				JsonSerializer.Serialize(writer, ResultsIndexNameValue, options);
			}

			writer.WriteEndObject();
		}
	}
}