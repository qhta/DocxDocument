namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of RecentFile objects that represents the files that have been used recently. The items in the
/// RecentFiles collection are displayed at the bottom of the File menu.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles?view=word-pia"/>
public partial interface RecentFiles : InteropObject, InteropCollection<RecentFile>
{
  /// <summary>
  /// Returns or sets the maximum number of recently used files that can appear on the File menu. Can be a number
  /// from 0 (zero) through 9.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.recentfiles.maximum?view=word-pia"/>
  public int Maximum { get; set; }
}
