namespace DocumentModel.Interfaces;

/// <summary>
/// A collection of Window objects that represent all the available windows.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows?view=word-pia"/>
public partial interface Windows : InteropObject, InteropCollection<Window>
{
  /// <summary>
  /// True enables scrolling of the contents of windows at the same time. False disables scrolling of windows at the
  /// same time.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.windows.syncscrollingsidebyside?view=word-pia"/>
  public bool SyncScrollingSideBySide { get; set; }
}
