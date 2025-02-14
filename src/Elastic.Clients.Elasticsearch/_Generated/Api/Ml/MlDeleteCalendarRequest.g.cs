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
	public sealed class MlDeleteCalendarRequestParameters : RequestParameters<MlDeleteCalendarRequestParameters>
	{
	}

	public partial class MlDeleteCalendarRequest : PlainRequestBase<MlDeleteCalendarRequestParameters>
	{
		public MlDeleteCalendarRequest(Elastic.Clients.Elasticsearch.Id calendar_id) : base(r => r.Required("calendar_id", calendar_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteCalendar;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public sealed partial class MlDeleteCalendarRequestDescriptor : RequestDescriptorBase<MlDeleteCalendarRequestDescriptor, MlDeleteCalendarRequestParameters>
	{
		internal MlDeleteCalendarRequestDescriptor(Action<MlDeleteCalendarRequestDescriptor> configure) => configure.Invoke(this);
		public MlDeleteCalendarRequestDescriptor(Elastic.Clients.Elasticsearch.Id calendar_id) : base(r => r.Required("calendar_id", calendar_id))
		{
		}

		internal MlDeleteCalendarRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningDeleteCalendar;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		public MlDeleteCalendarRequestDescriptor CalendarId(Elastic.Clients.Elasticsearch.Id calendar_id)
		{
			RouteValues.Required("calendar_id", calendar_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}