using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML project items contained in an HTML project.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems?view=office-pia
/// </remarks>
public partial interface HTMLProjectItems: InteropCollection<HTMLProjectItem>
{
}
