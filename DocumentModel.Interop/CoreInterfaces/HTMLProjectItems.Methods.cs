using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML project items contained in an HTML project.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems?view=office-pia
/// </remarks>
public partial interface HTMLProjectItems
{
  /// <summary>
  /// Returns the HTML project item that represents a particular project in the Microsoft Script Editor.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlprojectitems.item?view=office-pia
  /// </remarks>
  public HTMLProjectItem Item(ref object Index);
}
