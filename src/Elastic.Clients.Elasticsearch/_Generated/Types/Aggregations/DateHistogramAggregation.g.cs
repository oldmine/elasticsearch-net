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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class DateHistogramAggregationConverter : JsonConverter<DateHistogramAggregation>
	{
		public override DateHistogramAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "date_histogram")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new DateHistogramAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("calendar_interval"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval?>(ref reader, options);
						if (value is not null)
						{
							agg.CalendarInterval = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("fixed_interval"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Duration?>(ref reader, options);
						if (value is not null)
						{
							agg.FixedInterval = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("min_doc_count"))
					{
						var value = JsonSerializer.Deserialize<int?>(ref reader, options);
						if (value is not null)
						{
							agg.MinDocCount = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("missing"))
					{
						var value = JsonSerializer.Deserialize<DateTimeOffset?>(ref reader, options);
						if (value is not null)
						{
							agg.Missing = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("offset"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Duration?>(ref reader, options);
						if (value is not null)
						{
							agg.Offset = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("order"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.AggregateOrder?>(ref reader, options);
						if (value is not null)
						{
							agg.Order = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("params"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>?>(ref reader, options);
						if (value is not null)
						{
							agg.Params = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("time_zone"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.TimeZone = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("aggs") || reader.ValueTextEquals("aggregations"))
					{
						var value = JsonSerializer.Deserialize<AggregationDictionary>(ref reader, options);
						if (value is not null)
						{
							agg.Aggregations = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, DateHistogramAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("date_histogram");
			writer.WriteStartObject();
			if (value.CalendarInterval is not null)
			{
				writer.WritePropertyName("calendar_interval");
				JsonSerializer.Serialize(writer, value.CalendarInterval, options);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.FixedInterval is not null)
			{
				writer.WritePropertyName("fixed_interval");
				JsonSerializer.Serialize(writer, value.FixedInterval, options);
			}

			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.MinDocCount.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(value.MinDocCount.Value);
			}

			if (value.Missing is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, value.Missing, options);
			}

			if (value.Offset is not null)
			{
				writer.WritePropertyName("offset");
				JsonSerializer.Serialize(writer, value.Offset, options);
			}

			if (value.Order is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, value.Order, options);
			}

			if (value.Params is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, value.Params, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			if (value.TimeZone is not null)
			{
				writer.WritePropertyName("time_zone");
				JsonSerializer.Serialize(writer, value.TimeZone, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			if (value.Aggregations is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, value.Aggregations, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(DateHistogramAggregationConverter))]
	public partial class DateHistogramAggregation : BucketAggregationBase, TransformManagement.IPivotGroupByVariant
	{
		public DateHistogramAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("calendar_interval")]
		public Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("fixed_interval")]
		public Elastic.Clients.Elasticsearch.Duration? FixedInterval { get; set; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_doc_count")]
		public int? MinDocCount { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public DateTimeOffset? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("offset")]
		public Elastic.Clients.Elasticsearch.Duration? Offset { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.Aggregations.AggregateOrder? Order { get; set; }

		[JsonInclude]
		[JsonPropertyName("params")]
		public Dictionary<string, object>? Params { get; set; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public ScriptBase? Script { get; set; }

		[JsonInclude]
		[JsonPropertyName("time_zone")]
		public string? TimeZone { get; set; }
	}

	public sealed partial class DateHistogramAggregationDescriptor<TDocument> : SerializableDescriptorBase<DateHistogramAggregationDescriptor<TDocument>>
	{
		internal DateHistogramAggregationDescriptor(Action<DateHistogramAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public DateHistogramAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> AggregationsDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarIntervalValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? FixedIntervalValue { get; set; }

		private string? FormatValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private int? MinDocCountValue { get; set; }

		private DateTimeOffset? MissingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? OffsetValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregateOrder? OrderValue { get; set; }

		private Dictionary<string, object>? ParamsValue { get; set; }

		private string? TimeZoneValue { get; set; }

		public DateHistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument> descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor<TDocument>> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> CalendarInterval(Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? calendarInterval)
		{
			CalendarIntervalValue = calendarInterval;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> FixedInterval(Elastic.Clients.Elasticsearch.Duration? fixedInterval)
		{
			FixedIntervalValue = fixedInterval;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> MinDocCount(int? minDocCount)
		{
			MinDocCountValue = minDocCount;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Missing(DateTimeOffset? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Offset(Elastic.Clients.Elasticsearch.Duration? offset)
		{
			OffsetValue = offset;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.Aggregations.AggregateOrder? order)
		{
			OrderValue = order;
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public DateHistogramAggregationDescriptor<TDocument> TimeZone(string? timeZone)
		{
			TimeZoneValue = timeZone;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("date_histogram");
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (CalendarIntervalValue is not null)
			{
				writer.WritePropertyName("calendar_interval");
				JsonSerializer.Serialize(writer, CalendarIntervalValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (FixedIntervalValue is not null)
			{
				writer.WritePropertyName("fixed_interval");
				JsonSerializer.Serialize(writer, FixedIntervalValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MinDocCountValue.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(MinDocCountValue.Value);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (OffsetValue is not null)
			{
				writer.WritePropertyName("offset");
				JsonSerializer.Serialize(writer, OffsetValue, options);
			}

			if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (TimeZoneValue is not null)
			{
				writer.WritePropertyName("time_zone");
				JsonSerializer.Serialize(writer, TimeZoneValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor<TDocument>(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class DateHistogramAggregationDescriptor : SerializableDescriptorBase<DateHistogramAggregationDescriptor>
	{
		internal DateHistogramAggregationDescriptor(Action<DateHistogramAggregationDescriptor> configure) => configure.Invoke(this);
		public DateHistogramAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? AggregationsValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor AggregationsDescriptor { get; set; }

		private Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> AggregationsDescriptorAction { get; set; }

		private ScriptBase? ScriptValue { get; set; }

		private ScriptDescriptor ScriptDescriptor { get; set; }

		private Action<ScriptDescriptor> ScriptDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? CalendarIntervalValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? FixedIntervalValue { get; set; }

		private string? FormatValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private int? MinDocCountValue { get; set; }

		private DateTimeOffset? MissingValue { get; set; }

		private Elastic.Clients.Elasticsearch.Duration? OffsetValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.AggregateOrder? OrderValue { get; set; }

		private Dictionary<string, object>? ParamsValue { get; set; }

		private string? TimeZoneValue { get; set; }

		public DateHistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationDictionary? aggregations)
		{
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = null;
			AggregationsValue = aggregations;
			return Self;
		}

		public DateHistogramAggregationDescriptor Aggregations(Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor descriptor)
		{
			AggregationsValue = null;
			AggregationsDescriptorAction = null;
			AggregationsDescriptor = descriptor;
			return Self;
		}

		public DateHistogramAggregationDescriptor Aggregations(Action<Elastic.Clients.Elasticsearch.Aggregations.AggregationContainerDescriptor> configure)
		{
			AggregationsValue = null;
			AggregationsDescriptor = null;
			AggregationsDescriptorAction = configure;
			return Self;
		}

		public DateHistogramAggregationDescriptor Script(ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			ScriptValue = script;
			return Self;
		}

		public DateHistogramAggregationDescriptor Script(ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			ScriptDescriptor = descriptor;
			return Self;
		}

		public DateHistogramAggregationDescriptor Script(Action<ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptor = null;
			ScriptDescriptorAction = configure;
			return Self;
		}

		public DateHistogramAggregationDescriptor CalendarInterval(Elastic.Clients.Elasticsearch.Aggregations.CalendarInterval? calendarInterval)
		{
			CalendarIntervalValue = calendarInterval;
			return Self;
		}

		public DateHistogramAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
		{
			FieldValue = field;
			return Self;
		}

		public DateHistogramAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
		{
			FieldValue = field;
			return Self;
		}

		public DateHistogramAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
		{
			FieldValue = field;
			return Self;
		}

		public DateHistogramAggregationDescriptor FixedInterval(Elastic.Clients.Elasticsearch.Duration? fixedInterval)
		{
			FixedIntervalValue = fixedInterval;
			return Self;
		}

		public DateHistogramAggregationDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public DateHistogramAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public DateHistogramAggregationDescriptor MinDocCount(int? minDocCount)
		{
			MinDocCountValue = minDocCount;
			return Self;
		}

		public DateHistogramAggregationDescriptor Missing(DateTimeOffset? missing)
		{
			MissingValue = missing;
			return Self;
		}

		public DateHistogramAggregationDescriptor Offset(Elastic.Clients.Elasticsearch.Duration? offset)
		{
			OffsetValue = offset;
			return Self;
		}

		public DateHistogramAggregationDescriptor Order(Elastic.Clients.Elasticsearch.Aggregations.AggregateOrder? order)
		{
			OrderValue = order;
			return Self;
		}

		public DateHistogramAggregationDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public DateHistogramAggregationDescriptor TimeZone(string? timeZone)
		{
			TimeZoneValue = timeZone;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("date_histogram");
			writer.WriteStartObject();
			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			if (CalendarIntervalValue is not null)
			{
				writer.WritePropertyName("calendar_interval");
				JsonSerializer.Serialize(writer, CalendarIntervalValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (FixedIntervalValue is not null)
			{
				writer.WritePropertyName("fixed_interval");
				JsonSerializer.Serialize(writer, FixedIntervalValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (MinDocCountValue.HasValue)
			{
				writer.WritePropertyName("min_doc_count");
				writer.WriteNumberValue(MinDocCountValue.Value);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (OffsetValue is not null)
			{
				writer.WritePropertyName("offset");
				JsonSerializer.Serialize(writer, OffsetValue, options);
			}

			if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			if (ParamsValue is not null)
			{
				writer.WritePropertyName("params");
				JsonSerializer.Serialize(writer, ParamsValue, options);
			}

			if (TimeZoneValue is not null)
			{
				writer.WritePropertyName("time_zone");
				JsonSerializer.Serialize(writer, TimeZoneValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (AggregationsDescriptor is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsDescriptor, options);
			}
			else if (AggregationsDescriptorAction is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, new AggregationContainerDescriptor(AggregationsDescriptorAction), options);
			}
			else if (AggregationsValue is not null)
			{
				writer.WritePropertyName("aggregations");
				JsonSerializer.Serialize(writer, AggregationsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}