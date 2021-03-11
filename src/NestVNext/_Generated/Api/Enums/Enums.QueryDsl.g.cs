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
using System.Runtime.Serialization;

namespace Nest
{
    public enum ChildScoreMode
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "avg")]
        Avg,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "min")]
        Min
    }

    public enum FieldValueFactorModifier
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "log")]
        Log,
        [EnumMember(Value = "log1p")]
        Log1p,
        [EnumMember(Value = "log2p")]
        Log2p,
        [EnumMember(Value = "ln")]
        Ln,
        [EnumMember(Value = "ln1p")]
        Ln1p,
        [EnumMember(Value = "ln2p")]
        Ln2p,
        [EnumMember(Value = "square")]
        Square,
        [EnumMember(Value = "sqrt")]
        Sqrt,
        [EnumMember(Value = "reciprocal")]
        Reciprocal
    }

    public enum FunctionBoostMode
    {
        [EnumMember(Value = "multiply")]
        Multiply,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "avg")]
        Avg,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "min")]
        Min
    }

    public enum FunctionScoreMode
    {
        [EnumMember(Value = "multiply")]
        Multiply,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "avg")]
        Avg,
        [EnumMember(Value = "first")]
        First,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "min")]
        Min
    }

    public enum GeoExecution
    {
        [EnumMember(Value = "memory")]
        Memory,
        [EnumMember(Value = "indexed")]
        Indexed
    }

    public enum GeoValidationMethod
    {
        [EnumMember(Value = "coerce")]
        Coerce,
        [EnumMember(Value = "ignore_malformed")]
        IgnoreMalformed,
        [EnumMember(Value = "strict")]
        Strict
    }

    public enum MultiValueMode
    {
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "avg")]
        Avg,
        [EnumMember(Value = "sum")]
        Sum
    }

    public enum NestedScoreMode
    {
        [EnumMember(Value = "avg")]
        Avg,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "none")]
        None
    }

    public enum RangeRelation
    {
        [EnumMember(Value = "within")]
        Within,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "intersects")]
        Intersects
    }

    public enum SimpleQueryStringFlags
    {
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "AND")]
        And,
        [EnumMember(Value = "OR")]
        Or,
        [EnumMember(Value = "NOT")]
        Not,
        [EnumMember(Value = "PREFIX")]
        Prefix,
        [EnumMember(Value = "PHRASE")]
        Phrase,
        [EnumMember(Value = "PRECEDENCE")]
        Precedence,
        [EnumMember(Value = "ESCAPE")]
        Escape,
        [EnumMember(Value = "WHITESPACE")]
        Whitespace,
        [EnumMember(Value = "FUZZY")]
        Fuzzy,
        [EnumMember(Value = "NEAR")]
        Near,
        [EnumMember(Value = "SLOP")]
        Slop,
        [EnumMember(Value = "ALL")]
        All
    }

    public enum TextQueryType
    {
        [EnumMember(Value = "best_fields")]
        BestFields,
        [EnumMember(Value = "most_fields")]
        MostFields,
        [EnumMember(Value = "cross_fields")]
        CrossFields,
        [EnumMember(Value = "phrase")]
        Phrase,
        [EnumMember(Value = "phrase_prefix")]
        PhrasePrefix,
        [EnumMember(Value = "bool_prefix")]
        BoolPrefix
    }

    public enum ZeroTermsQuery
    {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "none")]
        None
    }
}