using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents a collection of ruler outline levels.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevels2?view=office-pia"/>
public partial interface RulerLevels2: InteropCollection<RulerLevel2>
{
}

