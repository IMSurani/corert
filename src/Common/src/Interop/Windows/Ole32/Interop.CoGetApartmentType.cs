// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal enum APTTYPE : uint
    {
        APTTYPE_STA = 0x0u,
        APTTYPE_MTA = 0x1u,
        APTTYPE_NA = 0x2u,
        APTTYPE_MAINSTA = 0x3u,
        APTTYPE_CURRENT = 0xFFFFFFFFu,
    }

    internal enum APTTYPEQUALIFIER : uint
    {
        APTTYPEQUALIFIER_NONE = 0x0u,
        APTTYPEQUALIFIER_IMPLICIT_MTA = 0x1u,
        APTTYPEQUALIFIER_NA_ON_MTA = 0x2u,
        APTTYPEQUALIFIER_NA_ON_STA = 0x3u,
        APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA = 0x4u,
        APTTYPEQUALIFIER_NA_ON_MAINSTA = 0x5u,
        APTTYPEQUALIFIER_APPLICATION_STA = 0x6u,
    }

    internal static partial class Ole32
    {
        [DllImport(Interop.Libraries.Ole32, ExactSpelling = true)]
        internal extern static int CoGetApartmentType(out APTTYPE pAptType, out APTTYPEQUALIFIER pAptQualifier);
    }
}
