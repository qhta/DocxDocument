namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Window objects that represent all the available windows.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows?view=word-pia"/>
public partial interface Windows : InteropObject, InteropCollection<Window>
{
  /// <summary>
  /// Returns or sets whether sync scrolling side by side.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows.syncscrollingsidebyside?view=word-pia"/>
  public bool SyncScrollingSideBySide { get; set; }
}
