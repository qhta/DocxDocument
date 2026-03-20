using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `GroupShapes` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes?view=office-pia` for Office interop details.
/// </remarks>
public partial interface GroupShapes: InteropDictionary<string, Shape>
{
}
