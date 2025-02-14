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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Security
{
	public sealed partial class SecuritySamlAuthenticateResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("access_token")]
		public string AccessToken { get; init; }

		[JsonInclude]
		[JsonPropertyName("expires_in")]
		public int ExpiresIn { get; init; }

		[JsonInclude]
		[JsonPropertyName("realm")]
		public string Realm { get; init; }

		[JsonInclude]
		[JsonPropertyName("refresh_token")]
		public string RefreshToken { get; init; }

		[JsonInclude]
		[JsonPropertyName("username")]
		public string Username { get; init; }
	}
}