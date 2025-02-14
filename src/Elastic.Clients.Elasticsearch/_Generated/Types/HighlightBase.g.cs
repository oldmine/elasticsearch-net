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
namespace Elastic.Clients.Elasticsearch
{
	public abstract partial class HighlightBase
	{
		[JsonInclude]
		[JsonPropertyName("boundary_chars")]
		public string? BoundaryChars { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_max_scan")]
		public int? BoundaryMaxScan { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_scanner")]
		public Elastic.Clients.Elasticsearch.BoundaryScanner? BoundaryScanner { get; set; }

		[JsonInclude]
		[JsonPropertyName("boundary_scanner_locale")]
		public string? BoundaryScannerLocale { get; set; }

		[JsonInclude]
		[JsonPropertyName("force_source")]
		public bool? ForceSource { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragment_size")]
		public int? FragmentSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("fragmenter")]
		public Elastic.Clients.Elasticsearch.HighlighterFragmenter? Fragmenter { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight_filter")]
		public bool? HighlightFilter { get; set; }

		[JsonInclude]
		[JsonPropertyName("highlight_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? HighlightQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_analyzed_offset")]
		public int? MaxAnalyzedOffset { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_fragment_length")]
		public int? MaxFragmentLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("no_match_size")]
		public int? NoMatchSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("number_of_fragments")]
		public int? NumberOfFragments { get; set; }

		[JsonInclude]
		[JsonPropertyName("options")]
		public Dictionary<string, object>? Options { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.HighlighterOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("phrase_limit")]
		public int? PhraseLimit { get; set; }

		[JsonInclude]
		[JsonPropertyName("post_tags")]
		public IEnumerable<string>? PostTags { get; set; }

		[JsonInclude]
		[JsonPropertyName("pre_tags")]
		public IEnumerable<string>? PreTags { get; set; }

		[JsonInclude]
		[JsonPropertyName("require_field_match")]
		public bool? RequireFieldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("tags_schema")]
		public Elastic.Clients.Elasticsearch.HighlighterTagsSchema? TagsSchema { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string? Type { get; set; }
	}
}