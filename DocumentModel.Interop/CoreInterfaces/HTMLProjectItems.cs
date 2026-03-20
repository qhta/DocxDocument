using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `HTMLProjectItems` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems?view=office-pia` for Office interop details.
/// </remarks>
public partial interface HTMLProjectItems: InteropCollection<HTMLProjectItem>
{
}
