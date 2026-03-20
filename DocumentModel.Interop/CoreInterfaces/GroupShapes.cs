using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.groupshapes?view=office-pia
/// </remarks>
public partial interface GroupShapes: InteropDictionary<string, Shape>
{
}
