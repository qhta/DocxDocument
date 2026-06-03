
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents items listed on the New Item task pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile?view=office-pia"/>
public interface INewFile: IInteropObject
{


  #region methods

/// <summary>
  /// Adds an item to the New Item task pane.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <param name="section">The `Section` parameter.</param>
  /// <param name="displayName">The `DisplayName` parameter.</param>
  /// <param name="action">The `Action` parameter.</param>
  /// <returns><see langword="true"/> if the item was added; otherwise, <see langword="false"/>.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile.add?view=office-pia"/>
  public bool Add(string fileName, object section, object displayName, object action);
  /// <summary>
  /// Removes an item from the New Item task pane.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <param name="section">The `Section` parameter.</param>
  /// <param name="displayName">The `DisplayName` parameter.</param>
  /// <param name="action">The `Action` parameter.</param>
  /// <returns><see langword="true"/> if the item was removed; otherwise, <see langword="false"/>.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile.remove?view=office-pia"/>
  public bool Remove(string fileName, object section, object displayName, object action);

  #endregion methods
}

