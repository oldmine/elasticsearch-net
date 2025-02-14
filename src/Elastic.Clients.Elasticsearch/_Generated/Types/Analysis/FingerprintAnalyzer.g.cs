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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class FingerprintAnalyzer : IAnalyzer
	{
		[JsonInclude]
		[JsonPropertyName("max_output_size")]
		public int MaxOutputSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool PreserveOriginal { get; set; }

		[JsonInclude]
		[JsonPropertyName("separator")]
		public string Separator { get; set; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; set; }

		[JsonInclude]
		[JsonPropertyName("stopwords_path")]
		public string? StopwordsPath { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "fingerprint";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; set; }
	}

	public sealed partial class FingerprintAnalyzerDescriptor : SerializableDescriptorBase<FingerprintAnalyzerDescriptor>, IBuildableDescriptor<FingerprintAnalyzer>
	{
		internal FingerprintAnalyzerDescriptor(Action<FingerprintAnalyzerDescriptor> configure) => configure.Invoke(this);
		public FingerprintAnalyzerDescriptor() : base()
		{
		}

		private int MaxOutputSizeValue { get; set; }

		private bool PreserveOriginalValue { get; set; }

		private string SeparatorValue { get; set; }

		private Elastic.Clients.Elasticsearch.Analysis.StopWords? StopwordsValue { get; set; }

		private string? StopwordsPathValue { get; set; }

		private string? VersionValue { get; set; }

		public FingerprintAnalyzerDescriptor MaxOutputSize(int maxOutputSize)
		{
			MaxOutputSizeValue = maxOutputSize;
			return Self;
		}

		public FingerprintAnalyzerDescriptor PreserveOriginal(bool preserveOriginal = true)
		{
			PreserveOriginalValue = preserveOriginal;
			return Self;
		}

		public FingerprintAnalyzerDescriptor Separator(string separator)
		{
			SeparatorValue = separator;
			return Self;
		}

		public FingerprintAnalyzerDescriptor Stopwords(Elastic.Clients.Elasticsearch.Analysis.StopWords? stopwords)
		{
			StopwordsValue = stopwords;
			return Self;
		}

		public FingerprintAnalyzerDescriptor StopwordsPath(string? stopwordsPath)
		{
			StopwordsPathValue = stopwordsPath;
			return Self;
		}

		public FingerprintAnalyzerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("max_output_size");
			writer.WriteNumberValue(MaxOutputSizeValue);
			writer.WritePropertyName("preserve_original");
			writer.WriteBooleanValue(PreserveOriginalValue);
			writer.WritePropertyName("separator");
			writer.WriteStringValue(SeparatorValue);
			if (StopwordsValue is not null)
			{
				writer.WritePropertyName("stopwords");
				JsonSerializer.Serialize(writer, StopwordsValue, options);
			}

			if (!string.IsNullOrEmpty(StopwordsPathValue))
			{
				writer.WritePropertyName("stopwords_path");
				writer.WriteStringValue(StopwordsPathValue);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("fingerprint");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		FingerprintAnalyzer IBuildableDescriptor<FingerprintAnalyzer>.Build() => new()
		{ MaxOutputSize = MaxOutputSizeValue, PreserveOriginal = PreserveOriginalValue, Separator = SeparatorValue, Stopwords = StopwordsValue, StopwordsPath = StopwordsPathValue, Version = VersionValue };
	}
}