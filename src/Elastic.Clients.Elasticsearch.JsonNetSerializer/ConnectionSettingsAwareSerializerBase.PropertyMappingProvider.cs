// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.Serialization;
using Elastic.Clients.Elasticsearch;
using Newtonsoft.Json;

namespace Elastic.Clients.JsonNetSerializer
{
	public abstract partial class ConnectionSettingsAwareSerializer : IPropertyMappingProvider
	{
		protected readonly ConcurrentDictionary<string, PropertyMapping> Properties = new();

		public PropertyMapping CreatePropertyMapping(MemberInfo memberInfo)
		{
			var memberInfoString = $"{memberInfo.DeclaringType?.FullName}.{memberInfo.Name}";
			if (Properties.TryGetValue(memberInfoString, out var mapping)) return mapping;
			mapping = FromAttributes(memberInfo);

			Properties.TryAdd(memberInfoString, mapping);
			return mapping;
		}

		private static PropertyMapping FromAttributes(MemberInfo memberInfo)
		{
			var jsonProperty = memberInfo.GetCustomAttribute<JsonPropertyAttribute>(true);
			var dataMemberProperty = memberInfo.GetCustomAttribute<DataMemberAttribute>(true);
			var jsonIgnore = memberInfo.GetCustomAttribute<JsonIgnoreAttribute>(true);

			if (jsonProperty is null && dataMemberProperty is null && jsonIgnore is null) return default;

			return new PropertyMapping
			{
				Name = jsonProperty?.PropertyName ?? dataMemberProperty?.Name,
				Ignore = jsonIgnore != null
			};
		}
	}
}
