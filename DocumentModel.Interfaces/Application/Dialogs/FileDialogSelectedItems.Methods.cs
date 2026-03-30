using System.Collections;
using System.Reflection;

namespace DocumentModel.Application;

/// <summary>
/// A collection of selected file or folder paths from a FileDialog.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogselecteditems?view=office-pia"/>
public partial interface IFileDialogSelectedItems: IModelObject
{
  /// <summary>
  /// Returns a selected path by index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogselecteditems.item?view=office-pia"/>
  public string Item(int Index);
}

