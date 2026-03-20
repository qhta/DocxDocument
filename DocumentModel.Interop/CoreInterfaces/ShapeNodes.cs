using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ShapeNodes` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shapenodes?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ShapeNodes: InteropDictionary<string, ShapeNode>
{
}
