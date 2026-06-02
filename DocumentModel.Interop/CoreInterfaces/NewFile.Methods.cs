
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents items listed on the New Item task pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile?view=office-pia"/>
public partial interface INewFile
{
  /// <summary>
  /// Adds an item to the New Item task pane.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="Section">The `Section` parameter.</param>
  /// <param name="DisplayName">The `DisplayName` parameter.</param>
  /// <param name="Action">The `Action` parameter.</param>
  /// <returns><see langword="true"/> if the item was added; otherwise, <see langword="false"/>.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile.add?view=office-pia"/>
  public bool Add(string FileName, object Section, object DisplayName, object Action);
  /// <summary>
  /// Removes an item from the New Item task pane.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="Section">The `Section` parameter.</param>
  /// <param name="DisplayName">The `DisplayName` parameter.</param>
  /// <param name="Action">The `Action` parameter.</param>
  /// <returns><see langword="true"/> if the item was removed; otherwise, <see langword="false"/>.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.newfile.remove?view=office-pia"/>
  public bool Remove(string FileName, object Section, object DisplayName, object Action);
}

