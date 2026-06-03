using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of FileDialogFilter objects used by a FileDialog.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters?view=office-pia"/>
public interface IFileDialogFilters: IInteropCollection<IFileDialogFilter>
{


  #region methods

/// <summary>
  /// Returns a filter by index.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters.item?view=office-pia"/>
  public IFileDialogFilter Item(int index);
  /// <summary>
  /// Removes a filter from the collection.
  /// </summary>
  /// <param name="filter">The `filter` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters.delete?view=office-pia"/>
  public void Delete(object filter);
  /// <summary>
  /// Adds a file filter to the collection.
  /// </summary>
  /// <param name="description">The `Description` parameter.</param>
  /// <param name="extensions">The `Extensions` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filedialogfilters.add?view=office-pia"/>
  public IFileDialogFilter Add(string description, string extensions, object position);

  #endregion methods
}

