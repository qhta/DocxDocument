namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Window objects that represent all the available windows.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows?view=word-pia"/>
public partial interface Windows : InteropObject, InteropCollection<Window>
{
  /// <summary>
  /// The sync scrolling side by side.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows.syncscrollingsidebyside?view=word-pia"/>
  public bool SyncScrollingSideBySide { get; set; }
}
