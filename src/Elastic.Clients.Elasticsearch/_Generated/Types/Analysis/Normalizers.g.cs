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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class Normalizers : IsADictionaryBase<string, INormalizer>
	{
		public Normalizers()
		{
		}

		public Normalizers(IDictionary<string, INormalizer> container) : base(container)
		{
		}

		public void Add(string name, INormalizer normalizers) => BackingDictionary.Add(name, normalizers);
	}

	public sealed partial class NormalizersDescriptor : IsADictionaryDescriptor<NormalizersDescriptor, Normalizers, string, INormalizer>
	{
		public NormalizersDescriptor() : base(new Normalizers())
		{
		}

		public NormalizersDescriptor(Normalizers normalizers) : base(normalizers ?? new Normalizers())
		{
		}

		public NormalizersDescriptor Custom(string normalizerName) => AssignVariant<CustomNormalizerDescriptor, CustomNormalizer>(normalizerName, null);
		public NormalizersDescriptor Custom(string normalizerName, Action<CustomNormalizerDescriptor> configure) => AssignVariant<CustomNormalizerDescriptor, CustomNormalizer>(normalizerName, configure);
		public NormalizersDescriptor Custom(string normalizerName, CustomNormalizer customNormalizer) => AssignVariant(normalizerName, customNormalizer);
		public NormalizersDescriptor Lowercase(string normalizerName) => AssignVariant<LowercaseNormalizerDescriptor, LowercaseNormalizer>(normalizerName, null);
		public NormalizersDescriptor Lowercase(string normalizerName, Action<LowercaseNormalizerDescriptor> configure) => AssignVariant<LowercaseNormalizerDescriptor, LowercaseNormalizer>(normalizerName, configure);
		public NormalizersDescriptor Lowercase(string normalizerName, LowercaseNormalizer lowercaseNormalizer) => AssignVariant(normalizerName, lowercaseNormalizer);
	}

	internal sealed partial class NormalizerInterfaceConverter
	{
		private static INormalizer DeserializeVariant(string type, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			switch (type)
			{
				case "custom":
					return JsonSerializer.Deserialize<CustomNormalizer>(ref reader, options);
				case "lowercase":
					return JsonSerializer.Deserialize<LowercaseNormalizer>(ref reader, options);
				default:
					throw new JsonException("Encounted an unknown variant type which could not be deserialised.");
			}
		}
	}

	public partial interface INormalizer
	{
		public string Type { get; }
	}
}