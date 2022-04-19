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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public partial class DataframeAnalysisOutlierDetection : IDataframeAnalysisContainerVariant
	{
		[JsonIgnore]
		string IDataframeAnalysisContainerVariant.DataframeAnalysisContainerVariantName => "outlier_detection";
		[JsonInclude]
		[JsonPropertyName("compute_feature_influence")]
		public bool? ComputeFeatureInfluence { get; set; }

		[JsonInclude]
		[JsonPropertyName("feature_influence_threshold")]
		public double? FeatureInfluenceThreshold { get; set; }

		[JsonInclude]
		[JsonPropertyName("method")]
		public string? Method { get; set; }

		[JsonInclude]
		[JsonPropertyName("n_neighbors")]
		public int? NNeighbors { get; set; }

		[JsonInclude]
		[JsonPropertyName("outlier_fraction")]
		public double? OutlierFraction { get; set; }

		[JsonInclude]
		[JsonPropertyName("standardization_enabled")]
		public bool? StandardizationEnabled { get; set; }
	}

	public sealed partial class DataframeAnalysisOutlierDetectionDescriptor : DescriptorBase<DataframeAnalysisOutlierDetectionDescriptor>
	{
		internal DataframeAnalysisOutlierDetectionDescriptor(Action<DataframeAnalysisOutlierDetectionDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalysisOutlierDetectionDescriptor() : base()
		{
		}

		private bool? ComputeFeatureInfluenceValue { get; set; }

		private double? FeatureInfluenceThresholdValue { get; set; }

		private string? MethodValue { get; set; }

		private int? NNeighborsValue { get; set; }

		private double? OutlierFractionValue { get; set; }

		private bool? StandardizationEnabledValue { get; set; }

		public DataframeAnalysisOutlierDetectionDescriptor ComputeFeatureInfluence(bool? computeFeatureInfluence = true)
		{
			ComputeFeatureInfluenceValue = computeFeatureInfluence;
			return Self;
		}

		public DataframeAnalysisOutlierDetectionDescriptor FeatureInfluenceThreshold(double? featureInfluenceThreshold)
		{
			FeatureInfluenceThresholdValue = featureInfluenceThreshold;
			return Self;
		}

		public DataframeAnalysisOutlierDetectionDescriptor Method(string? method)
		{
			MethodValue = method;
			return Self;
		}

		public DataframeAnalysisOutlierDetectionDescriptor NNeighbors(int? nNeighbors)
		{
			NNeighborsValue = nNeighbors;
			return Self;
		}

		public DataframeAnalysisOutlierDetectionDescriptor OutlierFraction(double? outlierFraction)
		{
			OutlierFractionValue = outlierFraction;
			return Self;
		}

		public DataframeAnalysisOutlierDetectionDescriptor StandardizationEnabled(bool? standardizationEnabled = true)
		{
			StandardizationEnabledValue = standardizationEnabled;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (ComputeFeatureInfluenceValue.HasValue)
			{
				writer.WritePropertyName("compute_feature_influence");
				writer.WriteBooleanValue(ComputeFeatureInfluenceValue.Value);
			}

			if (FeatureInfluenceThresholdValue.HasValue)
			{
				writer.WritePropertyName("feature_influence_threshold");
				writer.WriteNumberValue(FeatureInfluenceThresholdValue.Value);
			}

			if (!string.IsNullOrEmpty(MethodValue))
			{
				writer.WritePropertyName("method");
				writer.WriteStringValue(MethodValue);
			}

			if (NNeighborsValue.HasValue)
			{
				writer.WritePropertyName("n_neighbors");
				writer.WriteNumberValue(NNeighborsValue.Value);
			}

			if (OutlierFractionValue.HasValue)
			{
				writer.WritePropertyName("outlier_fraction");
				writer.WriteNumberValue(OutlierFractionValue.Value);
			}

			if (StandardizationEnabledValue.HasValue)
			{
				writer.WritePropertyName("standardization_enabled");
				writer.WriteBooleanValue(StandardizationEnabledValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}