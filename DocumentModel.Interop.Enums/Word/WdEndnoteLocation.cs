namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of endnotes.
/// </summary>
public enum WdEndnoteLocation
{
  /// <summary>
  /// At end of current section.
  /// </summary>
  Section = 0,
  /// <summary>
  /// At end of active document.
  /// </summary>
  Document = 1
}
