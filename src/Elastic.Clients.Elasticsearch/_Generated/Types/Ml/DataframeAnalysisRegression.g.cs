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
	public partial class DataframeAnalysisRegression : DataframeAnalysis, IDataframeAnalysisContainerVariant
	{
		[JsonIgnore]
		string IDataframeAnalysisContainerVariant.DataframeAnalysisContainerVariantName => "regression";
		[JsonInclude]
		[JsonPropertyName("loss_function")]
		public string? LossFunction { get; set; }

		[JsonInclude]
		[JsonPropertyName("loss_function_parameter")]
		public double? LossFunctionParameter { get; set; }
	}

	public sealed partial class DataframeAnalysisRegressionDescriptor<TDocument> : SerializableDescriptorBase<DataframeAnalysisRegressionDescriptor<TDocument>>
	{
		internal DataframeAnalysisRegressionDescriptor(Action<DataframeAnalysisRegressionDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DataframeAnalysisRegressionDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisFeatureProcessor>? FeatureProcessorsValue { get; set; }

		private double? AlphaValue { get; set; }

		private string DependentVariableValue { get; set; }

		private double? DownsampleFactorValue { get; set; }

		private bool? EarlyStoppingEnabledValue { get; set; }

		private double? EtaValue { get; set; }

		private double? EtaGrowthRatePerTreeValue { get; set; }

		private double? FeatureBagFractionValue { get; set; }

		private double? GammaValue { get; set; }

		private double? LambdaValue { get; set; }

		private string? LossFunctionValue { get; set; }

		private double? LossFunctionParameterValue { get; set; }

		private int? MaxOptimizationRoundsPerHyperparameterValue { get; set; }

		private int? MaxTreesValue { get; set; }

		private int? NumTopFeatureImportanceValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? PredictionFieldNameValue { get; set; }

		private double? RandomizeSeedValue { get; set; }

		private int? SoftTreeDepthLimitValue { get; set; }

		private double? SoftTreeDepthToleranceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Percentage? TrainingPercentValue { get; set; }

		public DataframeAnalysisRegressionDescriptor<TDocument> FeatureProcessors(IEnumerable<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisFeatureProcessor>? featureProcessors)
		{
			FeatureProcessorsValue = featureProcessors;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> Alpha(double? alpha)
		{
			AlphaValue = alpha;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> DependentVariable(string dependentVariable)
		{
			DependentVariableValue = dependentVariable;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> DownsampleFactor(double? downsampleFactor)
		{
			DownsampleFactorValue = downsampleFactor;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> EarlyStoppingEnabled(bool? earlyStoppingEnabled = true)
		{
			EarlyStoppingEnabledValue = earlyStoppingEnabled;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> Eta(double? eta)
		{
			EtaValue = eta;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> EtaGrowthRatePerTree(double? etaGrowthRatePerTree)
		{
			EtaGrowthRatePerTreeValue = etaGrowthRatePerTree;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> FeatureBagFraction(double? featureBagFraction)
		{
			FeatureBagFractionValue = featureBagFraction;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> Gamma(double? gamma)
		{
			GammaValue = gamma;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> Lambda(double? lambda)
		{
			LambdaValue = lambda;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> LossFunction(string? lossFunction)
		{
			LossFunctionValue = lossFunction;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> LossFunctionParameter(double? lossFunctionParameter)
		{
			LossFunctionParameterValue = lossFunctionParameter;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> MaxOptimizationRoundsPerHyperparameter(int? maxOptimizationRoundsPerHyperparameter)
		{
			MaxOptimizationRoundsPerHyperparameterValue = maxOptimizationRoundsPerHyperparameter;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> MaxTrees(int? maxTrees)
		{
			MaxTreesValue = maxTrees;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues)
		{
			NumTopFeatureImportanceValuesValue = numTopFeatureImportanceValues;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> PredictionFieldName(Elastic.Clients.Elasticsearch.Field? predictionFieldName)
		{
			PredictionFieldNameValue = predictionFieldName;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> PredictionFieldName<TValue>(Expression<Func<TDocument, TValue>> predictionFieldName)
		{
			PredictionFieldNameValue = predictionFieldName;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> RandomizeSeed(double? randomizeSeed)
		{
			RandomizeSeedValue = randomizeSeed;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> SoftTreeDepthLimit(int? softTreeDepthLimit)
		{
			SoftTreeDepthLimitValue = softTreeDepthLimit;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> SoftTreeDepthTolerance(double? softTreeDepthTolerance)
		{
			SoftTreeDepthToleranceValue = softTreeDepthTolerance;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor<TDocument> TrainingPercent(Elastic.Clients.Elasticsearch.Percentage? trainingPercent)
		{
			TrainingPercentValue = trainingPercent;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FeatureProcessorsValue is not null)
			{
				writer.WritePropertyName("feature_processors");
				JsonSerializer.Serialize(writer, FeatureProcessorsValue, options);
			}

			if (AlphaValue.HasValue)
			{
				writer.WritePropertyName("alpha");
				writer.WriteNumberValue(AlphaValue.Value);
			}

			writer.WritePropertyName("dependent_variable");
			writer.WriteStringValue(DependentVariableValue);
			if (DownsampleFactorValue.HasValue)
			{
				writer.WritePropertyName("downsample_factor");
				writer.WriteNumberValue(DownsampleFactorValue.Value);
			}

			if (EarlyStoppingEnabledValue.HasValue)
			{
				writer.WritePropertyName("early_stopping_enabled");
				writer.WriteBooleanValue(EarlyStoppingEnabledValue.Value);
			}

			if (EtaValue.HasValue)
			{
				writer.WritePropertyName("eta");
				writer.WriteNumberValue(EtaValue.Value);
			}

			if (EtaGrowthRatePerTreeValue.HasValue)
			{
				writer.WritePropertyName("eta_growth_rate_per_tree");
				writer.WriteNumberValue(EtaGrowthRatePerTreeValue.Value);
			}

			if (FeatureBagFractionValue.HasValue)
			{
				writer.WritePropertyName("feature_bag_fraction");
				writer.WriteNumberValue(FeatureBagFractionValue.Value);
			}

			if (GammaValue.HasValue)
			{
				writer.WritePropertyName("gamma");
				writer.WriteNumberValue(GammaValue.Value);
			}

			if (LambdaValue.HasValue)
			{
				writer.WritePropertyName("lambda");
				writer.WriteNumberValue(LambdaValue.Value);
			}

			if (!string.IsNullOrEmpty(LossFunctionValue))
			{
				writer.WritePropertyName("loss_function");
				writer.WriteStringValue(LossFunctionValue);
			}

			if (LossFunctionParameterValue.HasValue)
			{
				writer.WritePropertyName("loss_function_parameter");
				writer.WriteNumberValue(LossFunctionParameterValue.Value);
			}

			if (MaxOptimizationRoundsPerHyperparameterValue.HasValue)
			{
				writer.WritePropertyName("max_optimization_rounds_per_hyperparameter");
				writer.WriteNumberValue(MaxOptimizationRoundsPerHyperparameterValue.Value);
			}

			if (MaxTreesValue.HasValue)
			{
				writer.WritePropertyName("max_trees");
				writer.WriteNumberValue(MaxTreesValue.Value);
			}

			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (PredictionFieldNameValue is not null)
			{
				writer.WritePropertyName("prediction_field_name");
				JsonSerializer.Serialize(writer, PredictionFieldNameValue, options);
			}

			if (RandomizeSeedValue.HasValue)
			{
				writer.WritePropertyName("randomize_seed");
				writer.WriteNumberValue(RandomizeSeedValue.Value);
			}

			if (SoftTreeDepthLimitValue.HasValue)
			{
				writer.WritePropertyName("soft_tree_depth_limit");
				writer.WriteNumberValue(SoftTreeDepthLimitValue.Value);
			}

			if (SoftTreeDepthToleranceValue.HasValue)
			{
				writer.WritePropertyName("soft_tree_depth_tolerance");
				writer.WriteNumberValue(SoftTreeDepthToleranceValue.Value);
			}

			if (TrainingPercentValue is not null)
			{
				writer.WritePropertyName("training_percent");
				JsonSerializer.Serialize(writer, TrainingPercentValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class DataframeAnalysisRegressionDescriptor : SerializableDescriptorBase<DataframeAnalysisRegressionDescriptor>
	{
		internal DataframeAnalysisRegressionDescriptor(Action<DataframeAnalysisRegressionDescriptor> configure) => configure.Invoke(this);
		public DataframeAnalysisRegressionDescriptor() : base()
		{
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisFeatureProcessor>? FeatureProcessorsValue { get; set; }

		private double? AlphaValue { get; set; }

		private string DependentVariableValue { get; set; }

		private double? DownsampleFactorValue { get; set; }

		private bool? EarlyStoppingEnabledValue { get; set; }

		private double? EtaValue { get; set; }

		private double? EtaGrowthRatePerTreeValue { get; set; }

		private double? FeatureBagFractionValue { get; set; }

		private double? GammaValue { get; set; }

		private double? LambdaValue { get; set; }

		private string? LossFunctionValue { get; set; }

		private double? LossFunctionParameterValue { get; set; }

		private int? MaxOptimizationRoundsPerHyperparameterValue { get; set; }

		private int? MaxTreesValue { get; set; }

		private int? NumTopFeatureImportanceValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? PredictionFieldNameValue { get; set; }

		private double? RandomizeSeedValue { get; set; }

		private int? SoftTreeDepthLimitValue { get; set; }

		private double? SoftTreeDepthToleranceValue { get; set; }

		private Elastic.Clients.Elasticsearch.Percentage? TrainingPercentValue { get; set; }

		public DataframeAnalysisRegressionDescriptor FeatureProcessors(IEnumerable<Elastic.Clients.Elasticsearch.Ml.DataframeAnalysisFeatureProcessor>? featureProcessors)
		{
			FeatureProcessorsValue = featureProcessors;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor Alpha(double? alpha)
		{
			AlphaValue = alpha;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor DependentVariable(string dependentVariable)
		{
			DependentVariableValue = dependentVariable;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor DownsampleFactor(double? downsampleFactor)
		{
			DownsampleFactorValue = downsampleFactor;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor EarlyStoppingEnabled(bool? earlyStoppingEnabled = true)
		{
			EarlyStoppingEnabledValue = earlyStoppingEnabled;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor Eta(double? eta)
		{
			EtaValue = eta;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor EtaGrowthRatePerTree(double? etaGrowthRatePerTree)
		{
			EtaGrowthRatePerTreeValue = etaGrowthRatePerTree;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor FeatureBagFraction(double? featureBagFraction)
		{
			FeatureBagFractionValue = featureBagFraction;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor Gamma(double? gamma)
		{
			GammaValue = gamma;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor Lambda(double? lambda)
		{
			LambdaValue = lambda;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor LossFunction(string? lossFunction)
		{
			LossFunctionValue = lossFunction;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor LossFunctionParameter(double? lossFunctionParameter)
		{
			LossFunctionParameterValue = lossFunctionParameter;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor MaxOptimizationRoundsPerHyperparameter(int? maxOptimizationRoundsPerHyperparameter)
		{
			MaxOptimizationRoundsPerHyperparameterValue = maxOptimizationRoundsPerHyperparameter;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor MaxTrees(int? maxTrees)
		{
			MaxTreesValue = maxTrees;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues)
		{
			NumTopFeatureImportanceValuesValue = numTopFeatureImportanceValues;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor PredictionFieldName(Elastic.Clients.Elasticsearch.Field? predictionFieldName)
		{
			PredictionFieldNameValue = predictionFieldName;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor PredictionFieldName<TDocument, TValue>(Expression<Func<TDocument, TValue>> predictionFieldName)
		{
			PredictionFieldNameValue = predictionFieldName;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor PredictionFieldName<TDocument>(Expression<Func<TDocument, object>> predictionFieldName)
		{
			PredictionFieldNameValue = predictionFieldName;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor RandomizeSeed(double? randomizeSeed)
		{
			RandomizeSeedValue = randomizeSeed;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor SoftTreeDepthLimit(int? softTreeDepthLimit)
		{
			SoftTreeDepthLimitValue = softTreeDepthLimit;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor SoftTreeDepthTolerance(double? softTreeDepthTolerance)
		{
			SoftTreeDepthToleranceValue = softTreeDepthTolerance;
			return Self;
		}

		public DataframeAnalysisRegressionDescriptor TrainingPercent(Elastic.Clients.Elasticsearch.Percentage? trainingPercent)
		{
			TrainingPercentValue = trainingPercent;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FeatureProcessorsValue is not null)
			{
				writer.WritePropertyName("feature_processors");
				JsonSerializer.Serialize(writer, FeatureProcessorsValue, options);
			}

			if (AlphaValue.HasValue)
			{
				writer.WritePropertyName("alpha");
				writer.WriteNumberValue(AlphaValue.Value);
			}

			writer.WritePropertyName("dependent_variable");
			writer.WriteStringValue(DependentVariableValue);
			if (DownsampleFactorValue.HasValue)
			{
				writer.WritePropertyName("downsample_factor");
				writer.WriteNumberValue(DownsampleFactorValue.Value);
			}

			if (EarlyStoppingEnabledValue.HasValue)
			{
				writer.WritePropertyName("early_stopping_enabled");
				writer.WriteBooleanValue(EarlyStoppingEnabledValue.Value);
			}

			if (EtaValue.HasValue)
			{
				writer.WritePropertyName("eta");
				writer.WriteNumberValue(EtaValue.Value);
			}

			if (EtaGrowthRatePerTreeValue.HasValue)
			{
				writer.WritePropertyName("eta_growth_rate_per_tree");
				writer.WriteNumberValue(EtaGrowthRatePerTreeValue.Value);
			}

			if (FeatureBagFractionValue.HasValue)
			{
				writer.WritePropertyName("feature_bag_fraction");
				writer.WriteNumberValue(FeatureBagFractionValue.Value);
			}

			if (GammaValue.HasValue)
			{
				writer.WritePropertyName("gamma");
				writer.WriteNumberValue(GammaValue.Value);
			}

			if (LambdaValue.HasValue)
			{
				writer.WritePropertyName("lambda");
				writer.WriteNumberValue(LambdaValue.Value);
			}

			if (!string.IsNullOrEmpty(LossFunctionValue))
			{
				writer.WritePropertyName("loss_function");
				writer.WriteStringValue(LossFunctionValue);
			}

			if (LossFunctionParameterValue.HasValue)
			{
				writer.WritePropertyName("loss_function_parameter");
				writer.WriteNumberValue(LossFunctionParameterValue.Value);
			}

			if (MaxOptimizationRoundsPerHyperparameterValue.HasValue)
			{
				writer.WritePropertyName("max_optimization_rounds_per_hyperparameter");
				writer.WriteNumberValue(MaxOptimizationRoundsPerHyperparameterValue.Value);
			}

			if (MaxTreesValue.HasValue)
			{
				writer.WritePropertyName("max_trees");
				writer.WriteNumberValue(MaxTreesValue.Value);
			}

			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (PredictionFieldNameValue is not null)
			{
				writer.WritePropertyName("prediction_field_name");
				JsonSerializer.Serialize(writer, PredictionFieldNameValue, options);
			}

			if (RandomizeSeedValue.HasValue)
			{
				writer.WritePropertyName("randomize_seed");
				writer.WriteNumberValue(RandomizeSeedValue.Value);
			}

			if (SoftTreeDepthLimitValue.HasValue)
			{
				writer.WritePropertyName("soft_tree_depth_limit");
				writer.WriteNumberValue(SoftTreeDepthLimitValue.Value);
			}

			if (SoftTreeDepthToleranceValue.HasValue)
			{
				writer.WritePropertyName("soft_tree_depth_tolerance");
				writer.WriteNumberValue(SoftTreeDepthToleranceValue.Value);
			}

			if (TrainingPercentValue is not null)
			{
				writer.WritePropertyName("training_percent");
				JsonSerializer.Serialize(writer, TrainingPercentValue, options);
			}

			writer.WriteEndObject();
		}
	}
}