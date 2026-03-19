namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of RecentFile objects that represents the files that have been used recently. The items in the RecentFiles collection are displayed at the bottom of the File menu.
/// </summary>
public partial interface RecentFiles : InteropObject, InteropCollection<RecentFile>
{
  /// <summary>
  /// The maximum.
  /// </summary>
  public int Maximum { get; set; }
}
