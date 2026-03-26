namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies when scroll bars are available for the specified frame when viewing its frames page in a Web
/// browser.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdscrollbartype?view=office-pia` for Office interop details.
/// </remarks>
public enum ScrollbarType
{
  /// <summary>
  /// Scroll bars are available for the specified frame only if the contents are too large to fit in the allotted
  /// space.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// Scroll bars are always available for the specified frame.
  /// </summary>
  Yes = 1,
  /// <summary>
  /// Scroll bars are never available for the specified frame.
  /// </summary>
  No = 2
}
