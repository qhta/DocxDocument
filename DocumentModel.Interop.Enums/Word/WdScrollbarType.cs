namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies when scroll bars are available for the specified frame when viewing its frames page in a Web
/// browser.
/// </summary>
public enum WdScrollbarType
{
  /// <summary>
  /// Specifies when scroll bars are available for the specified frame when viewing its frames page in a Web
  /// browser.
  /// </summary>
  wdScrollbarTypeAuto = unchecked((int)0),
  /// <summary>
  /// Scroll bars are always available for the specified frame.
  /// </summary>
  wdScrollbarTypeYes = unchecked((int)1),
  /// <summary>
  /// Scroll bars are never available for the specified frame.
  /// </summary>
  wdScrollbarTypeNo = unchecked((int)2)
}
