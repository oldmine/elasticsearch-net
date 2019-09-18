﻿using System;
using Newtonsoft.Json;

namespace Nest
{
	internal class PropertyNameJsonConverter : JsonConverter
	{
		public override bool CanRead => false;

		public override bool CanWrite => true;

		public override bool CanConvert(Type objectType) => true;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			var property = value as PropertyName;
			if (property == null)
			{
				writer.WriteNull();
				return;
			}
			var infer = serializer.GetConnectionSettings().Inferrer;
			writer.WriteValue(infer.PropertyName(property));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => null;
	}
}