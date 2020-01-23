﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Composition;
using Microsoft.CodeAnalysis.Formatting;
using Microsoft.CodeAnalysis.Host.Mef;

namespace Microsoft.CodeAnalysis.CSharp.Formatting
{
    [ExportLanguageService(typeof(IFormattingService), LanguageNames.CSharp), Shared]
    internal class CSharpFormattingService : AbstractFormattingService
    {
        [ImportingConstructor]
        public CSharpFormattingService()
        {
        }
    }
}
