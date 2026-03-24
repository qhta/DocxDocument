namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of footnotes.
/// </summary>
public enum WdFootnoteLocation
{
  /// <summary>
  /// At bottom of current page.
  /// </summary>
  ottomOfPage = unchecked((int)0),
  /// <summary>
  /// Beneath current text.
  /// </summary>
  eneathText = unchecked((int)1)
}
