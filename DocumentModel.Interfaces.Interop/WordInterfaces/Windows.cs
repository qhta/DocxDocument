namespace DocumentModel.Interop;

/// <summary>
/// A collection of Window objects that represent all the available windows.
/// </summary>
public partial interface Windows : InteropObject, InteropCollection<Window>
{
  /// <summary>
  /// The sync scrolling side by side.
  /// </summary>
  public bool SyncScrollingSideBySide { get; set; }
}
