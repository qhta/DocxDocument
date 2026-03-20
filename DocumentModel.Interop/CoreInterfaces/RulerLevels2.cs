using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of ruler outline levels.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2?view=office-pia
/// </remarks>
public partial interface RulerLevels2: InteropDictionary<string, RulerLevel2>
{
}
