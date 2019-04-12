﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	public interface IHasPrivilegesResponse : IResponse
	{
		[DataMember(Name = "application")]
		[JsonFormatter(typeof(ApplicationsPrivilegesFormatter))]
		IReadOnlyDictionary<string, IReadOnlyCollection<ResourcePrivileges>> Applications { get; }

		[DataMember(Name = "cluster")]
		IReadOnlyDictionary<string, bool> Clusters { get; }

		[DataMember(Name = "has_all_requested")]
		bool HasAllRequested { get; }

		[DataMember(Name = "index")]
		[JsonFormatter(typeof(IndicesPrivilegesFormatter))]
		IReadOnlyCollection<ResourcePrivileges> Indices { get; }

		[DataMember(Name = "username")]
		string Username { get; }
	}

	public class HasPrivilegesResponse : ResponseBase, IHasPrivilegesResponse
	{
		public IReadOnlyDictionary<string, IReadOnlyCollection<ResourcePrivileges>> Applications { get; internal set; } =
			EmptyReadOnly<string, IReadOnlyCollection<ResourcePrivileges>>.Dictionary;

		public IReadOnlyDictionary<string, bool> Clusters { get; internal set; } = EmptyReadOnly<string, bool>.Dictionary;
		public bool HasAllRequested { get; internal set; }

		public IReadOnlyCollection<ResourcePrivileges> Indices { get; internal set; } = EmptyReadOnly<ResourcePrivileges>.Collection;
		public string Username { get; internal set; }
	}

	public class ResourcePrivileges
	{
		public IReadOnlyDictionary<string, bool> Privileges { get; internal set; } = EmptyReadOnly<string, bool>.Dictionary;
		public string Resource { get; internal set; }
	}

	internal class IndicesPrivilegesFormatter : IJsonFormatter<IReadOnlyCollection<ResourcePrivileges>>
	{
		public IReadOnlyCollection<ResourcePrivileges> Deserialize(ref JsonReader reader, IJsonFormatterResolver formatterResolver) =>
			ReadResourcePrivileges(ref reader, formatterResolver);

		public void Serialize(ref JsonWriter writer, IReadOnlyCollection<ResourcePrivileges> value, IJsonFormatterResolver formatterResolver)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}

			writer.WriteBeginObject();
			var count = 0;
			var formatter = formatterResolver.GetFormatter<IReadOnlyDictionary<string, bool>>();
			foreach (var privilege in value)
			{
				if (count > 0)
					writer.WriteValueSeparator();

				writer.WritePropertyName(privilege.Resource);
				formatter.Serialize(ref writer, privilege.Privileges, formatterResolver);

				count++;
			}
			writer.WriteEndObject();
		}

		internal static IReadOnlyCollection<ResourcePrivileges> ReadResourcePrivileges(ref JsonReader reader, IJsonFormatterResolver formatterResolver
		)
		{
			if (reader.ReadIsNull())
				return null;

			var privileges = new List<ResourcePrivileges>();
			var count = 0;
			var formatter = formatterResolver.GetFormatter<IReadOnlyDictionary<string, bool>>();

			while (reader.ReadIsInObject(ref count))
			{
				var resource = reader.ReadPropertyName();
				var resourcePrivileges = formatter.Deserialize(ref reader, formatterResolver);
				privileges.Add(new ResourcePrivileges { Resource = resource, Privileges = resourcePrivileges });
			}

			return privileges;
		}
	}

	internal class ApplicationsPrivilegesFormatter : IJsonFormatter<IReadOnlyDictionary<string, IReadOnlyCollection<ResourcePrivileges>>>
	{
		private static readonly IndicesPrivilegesFormatter Formatter = new IndicesPrivilegesFormatter();

		public IReadOnlyDictionary<string, IReadOnlyCollection<ResourcePrivileges>> Deserialize(ref JsonReader reader,
			IJsonFormatterResolver formatterResolver
		)
		{
			if (reader.ReadIsNull())
				return null;

			var apps = new Dictionary<string, IReadOnlyCollection<ResourcePrivileges>>();
			var count = 0;
			while (reader.ReadIsInObject(ref count))
			{
				var app = reader.ReadPropertyName();
				var privileges = Formatter.Deserialize(ref reader, formatterResolver);
				apps.Add(app, privileges);
			}

			return apps;
		}

		public void Serialize(ref JsonWriter writer, IReadOnlyDictionary<string, IReadOnlyCollection<ResourcePrivileges>> value,
			IJsonFormatterResolver formatterResolver
		)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}

			writer.WriteBeginObject();
			var count = 0;
			foreach (var privilege in value)
			{
				if (count > 0)
					writer.WriteValueSeparator();

				writer.WritePropertyName(privilege.Key);
				Formatter.Serialize(ref writer, privilege.Value, formatterResolver);
				count++;
			}
			writer.WriteEndObject();
		}
	}
}