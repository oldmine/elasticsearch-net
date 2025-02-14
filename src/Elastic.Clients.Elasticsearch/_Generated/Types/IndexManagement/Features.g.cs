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
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	[SingleOrMany(typeof(Elastic.Clients.Elasticsearch.IndexManagement.Feature))]
	public partial class Features : IList<Elastic.Clients.Elasticsearch.IndexManagement.Feature>
	{
		private readonly IList<Elastic.Clients.Elasticsearch.IndexManagement.Feature> _backingList = new List<Elastic.Clients.Elasticsearch.IndexManagement.Feature>();
		public Elastic.Clients.Elasticsearch.IndexManagement.Feature this[int index] { get => _backingList[index]; set => _backingList[index] = value; }

		public int Count => _backingList.Count;
		public bool IsReadOnly => _backingList.IsReadOnly;
		public void Add(Elastic.Clients.Elasticsearch.IndexManagement.Feature item) => _backingList.Add(item);
		public void Clear() => _backingList.Clear();
		public bool Contains(Elastic.Clients.Elasticsearch.IndexManagement.Feature item) => _backingList.Contains(item);
		public void CopyTo(Elastic.Clients.Elasticsearch.IndexManagement.Feature[] array, int arrayIndex) => _backingList.CopyTo(array, arrayIndex);
		public IEnumerator<Elastic.Clients.Elasticsearch.IndexManagement.Feature> GetEnumerator() => _backingList.GetEnumerator();
		public int IndexOf(Elastic.Clients.Elasticsearch.IndexManagement.Feature item) => _backingList.IndexOf(item);
		public void Insert(int index, Elastic.Clients.Elasticsearch.IndexManagement.Feature item) => _backingList.Insert(index, item);
		public bool Remove(Elastic.Clients.Elasticsearch.IndexManagement.Feature item) => _backingList.Remove(item);
		public void RemoveAt(int index) => _backingList.RemoveAt(index);
		IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_backingList).GetEnumerator();
	}
}