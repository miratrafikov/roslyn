﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable

using System;
using System.Collections.Generic;

#if CODE_STYLE
namespace Microsoft.CodeAnalysis.Internal.Options
{
    public interface IEditorConfigStorageLocation
#else
namespace Microsoft.CodeAnalysis.Options
{
    internal interface IEditorConfigStorageLocation
#endif
    {
        bool TryGetOption(IReadOnlyDictionary<string, string?> rawOptions, Type type, out object? value);
    }
}
