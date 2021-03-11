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
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using System;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public interface IClearSqlCursorRequest : IRequest<ClearSqlCursorRequestParameters>
    {
    }

    public class ClearSqlCursorRequest : PlainRequestBase<ClearSqlCursorRequestParameters>, IClearSqlCursorRequest
    {
        protected IClearSqlCursorRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlClearCursor;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
        ///<summary>/_sql/close</summary>
        public ClearSqlCursorRequest(): base()
        {
        }
    }

    public interface IQuerySqlRequest : IRequest<QuerySqlRequestParameters>
    {
    }

    public class QuerySqlRequest : PlainRequestBase<QuerySqlRequestParameters>, IQuerySqlRequest
    {
        protected IQuerySqlRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlQuery;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
        ///<summary>/_sql</summary>
        public QuerySqlRequest(): base()
        {
        }

        public string? Format { get => Q<string?>("format"); set => Q("format", value); }
    }

    public interface ITranslateSqlRequest : IRequest<TranslateSqlRequestParameters>
    {
    }

    public class TranslateSqlRequest : PlainRequestBase<TranslateSqlRequestParameters>, ITranslateSqlRequest
    {
        protected ITranslateSqlRequest Self => this;
        internal override ApiUrls ApiUrls => ApiUrlsLookups.SqlTranslate;
        protected override HttpMethod HttpMethod => HttpMethod.POST;
        protected override bool SupportsBody => false;
        ///<summary>/_sql/translate</summary>
        public TranslateSqlRequest(): base()
        {
        }
    }
}