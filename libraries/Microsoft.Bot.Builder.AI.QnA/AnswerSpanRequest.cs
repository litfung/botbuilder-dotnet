﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace Microsoft.Bot.Builder.AI.QnA
{
    public class AnswerSpanRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether to enable PreciseAnswer generation or not. User can choose to use this feature of QnAMaker 
        /// Service using this configuration.
        /// </summary>
        /// <value>
        /// Choice whether to generate precise answer or not.
        /// </value>
        [JsonProperty("enable")]
        public bool Enable { get; set; }
    }
}