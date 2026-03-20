using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of selected file or folder paths from a FileDialog.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogselecteditems?view=office-pia
/// </remarks>
public partial interface FileDialogSelectedItems
{
  /// <summary>
  /// Returns a selected path by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogselecteditems.item?view=office-pia
  /// </remarks>
  public string Item(int Index);
}
