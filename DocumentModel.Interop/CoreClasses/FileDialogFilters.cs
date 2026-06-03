using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of FileDialogFilter objects used by a FileDialog.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters?view=office-pia"/>
public partial class FileDialogFilters: InteropCollection<FileDialogFilter>
{


  #region methods

/// <summary>
  /// Returns a filter by index.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters.item?view=office-pia"/>
  public FileDialogFilter Item(int index) { throw new NotImplementedException(); }
  /// <summary>
  /// Removes a filter from the collection.
  /// </summary>
  /// <param name="filter">The `filter` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters.delete?view=office-pia"/>
  public void Delete(object filter) { throw new NotImplementedException(); }
  /// <summary>
  /// Adds a file filter to the collection.
  /// </summary>
  /// <param name="description">The `Description` parameter.</param>
  /// <param name="extensions">The `Extensions` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters.add?view=office-pia"/>
  public FileDialogFilter Add(string description, string extensions, object position) { throw new NotImplementedException(); }

  #endregion methods
}

