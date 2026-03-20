using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `RulerLevels2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface RulerLevels2: InteropDictionary<string, RulerLevel2>
{
}
