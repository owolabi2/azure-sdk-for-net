// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Splits words into subwords and performs optional transformations on
    /// subword groups. This token filter is implemented using Apache Lucene.
    /// <see href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/WordDelimiterFilter.html" />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.WordDelimiterTokenFilter")]
    public partial class WordDelimiterTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the WordDelimiterTokenFilter class.
        /// </summary>
        public WordDelimiterTokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the WordDelimiterTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="generateWordParts">A value indicating whether to
        /// generate part words. If set, causes parts of words to be generated;
        /// for example "AzureSearch" becomes "Azure" "Search". Default is
        /// true.</param>
        /// <param name="generateNumberParts">A value indicating whether to
        /// generate number subwords. Default is true.</param>
        /// <param name="catenateWords">A value indicating whether maximum runs
        /// of word parts will be catenated. For example, if this is set to
        /// true, "Azure-Search" becomes "AzureSearch". Default is
        /// false.</param>
        /// <param name="catenateNumbers">A value indicating whether maximum
        /// runs of number parts will be catenated. For example, if this is set
        /// to true, "1-2" becomes "12". Default is false.</param>
        /// <param name="catenateAll">A value indicating whether all subword
        /// parts will be catenated. For example, if this is set to true,
        /// "Azure-Search-1" becomes "AzureSearch1". Default is false.</param>
        /// <param name="splitOnCaseChange">A value indicating whether to split
        /// words on caseChange. For example, if this is set to true,
        /// "AzureSearch" becomes "Azure" "Search". Default is true.</param>
        /// <param name="preserveOriginal">A value indicating whether original
        /// words will be preserved and added to the subword list. Default is
        /// false.</param>
        /// <param name="splitOnNumerics">A value indicating whether to split
        /// on numbers. For example, if this is set to true, "Azure1Search"
        /// becomes "Azure" "1" "Search". Default is true.</param>
        /// <param name="stemEnglishPossessive">A value indicating whether to
        /// remove trailing "'s" for each subword. Default is true.</param>
        /// <param name="protectedWords">A list of tokens to protect from being
        /// delimited.</param>
        public WordDelimiterTokenFilter(string name, bool? generateWordParts = default(bool?), bool? generateNumberParts = default(bool?), bool? catenateWords = default(bool?), bool? catenateNumbers = default(bool?), bool? catenateAll = default(bool?), bool? splitOnCaseChange = default(bool?), bool? preserveOriginal = default(bool?), bool? splitOnNumerics = default(bool?), bool? stemEnglishPossessive = default(bool?), IList<string> protectedWords = default(IList<string>))
            : base(name)
        {
            GenerateWordParts = generateWordParts;
            GenerateNumberParts = generateNumberParts;
            CatenateWords = catenateWords;
            CatenateNumbers = catenateNumbers;
            CatenateAll = catenateAll;
            SplitOnCaseChange = splitOnCaseChange;
            PreserveOriginal = preserveOriginal;
            SplitOnNumerics = splitOnNumerics;
            StemEnglishPossessive = stemEnglishPossessive;
            ProtectedWords = protectedWords;
        }

        /// <summary>
        /// Gets or sets a value indicating whether to generate part words. If
        /// set, causes parts of words to be generated; for example
        /// "AzureSearch" becomes "Azure" "Search". Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "generateWordParts")]
        public bool? GenerateWordParts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to generate number
        /// subwords. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "generateNumberParts")]
        public bool? GenerateNumberParts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether maximum runs of word parts
        /// will be catenated. For example, if this is set to true,
        /// "Azure-Search" becomes "AzureSearch". Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "catenateWords")]
        public bool? CatenateWords { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether maximum runs of number
        /// parts will be catenated. For example, if this is set to true, "1-2"
        /// becomes "12". Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "catenateNumbers")]
        public bool? CatenateNumbers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether all subword parts will be
        /// catenated. For example, if this is set to true, "Azure-Search-1"
        /// becomes "AzureSearch1". Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "catenateAll")]
        public bool? CatenateAll { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to split words on
        /// caseChange. For example, if this is set to true, "AzureSearch"
        /// becomes "Azure" "Search". Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "splitOnCaseChange")]
        public bool? SplitOnCaseChange { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether original words will be
        /// preserved and added to the subword list. Default is false.
        /// </summary>
        [JsonProperty(PropertyName = "preserveOriginal")]
        public bool? PreserveOriginal { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to split on numbers. For
        /// example, if this is set to true, "Azure1Search" becomes "Azure" "1"
        /// "Search". Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "splitOnNumerics")]
        public bool? SplitOnNumerics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to remove trailing "'s" for
        /// each subword. Default is true.
        /// </summary>
        [JsonProperty(PropertyName = "stemEnglishPossessive")]
        public bool? StemEnglishPossessive { get; set; }

        /// <summary>
        /// Gets or sets a list of tokens to protect from being delimited.
        /// </summary>
        [JsonProperty(PropertyName = "protectedWords")]
        public IList<string> ProtectedWords { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

