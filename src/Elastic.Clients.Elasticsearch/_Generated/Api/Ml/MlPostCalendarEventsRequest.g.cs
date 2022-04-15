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
	public class MlPostCalendarEventsRequestParameters : RequestParameters<MlPostCalendarEventsRequestParameters>
	{
	}

	public partial class MlPostCalendarEventsRequest : PlainRequestBase<MlPostCalendarEventsRequestParameters>
	{
		public MlPostCalendarEventsRequest(Elastic.Clients.Elasticsearch.Id calendar_id) : base(r => r.Required("calendar_id", calendar_id))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningPostCalendarEvents;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("events")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Ml.CalendarEvent> Events { get; set; }
	}

	public sealed partial class MlPostCalendarEventsRequestDescriptor : RequestDescriptorBase<MlPostCalendarEventsRequestDescriptor, MlPostCalendarEventsRequestParameters>
	{
		internal MlPostCalendarEventsRequestDescriptor(Action<MlPostCalendarEventsRequestDescriptor> configure) => configure.Invoke(this);
		public MlPostCalendarEventsRequestDescriptor(Elastic.Clients.Elasticsearch.Id calendar_id) : base(r => r.Required("calendar_id", calendar_id))
		{
		}

		internal MlPostCalendarEventsRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningPostCalendarEvents;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public MlPostCalendarEventsRequestDescriptor CalendarId(Elastic.Clients.Elasticsearch.Id calendar_id)
		{
			RouteValues.Required("calendar_id", calendar_id);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.Ml.CalendarEvent> EventsValue { get; set; }

		public MlPostCalendarEventsRequestDescriptor Events(IEnumerable<Elastic.Clients.Elasticsearch.Ml.CalendarEvent> events)
		{
			EventsValue = events;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("events");
			JsonSerializer.Serialize(writer, EventsValue, options);
			writer.WriteEndObject();
		}
	}
}