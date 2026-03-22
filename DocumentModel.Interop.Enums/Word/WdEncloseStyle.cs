namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative size of an enclosure.
/// </summary>
public enum WdEncloseStyle
{
  /// <summary>
  /// The enclosure assumes the default size.
  /// </summary>
  wdEncloseStyleNone = unchecked((int)0),
  /// <summary>
  /// The enclosure is smaller.
  /// </summary>
  wdEncloseStyleSmall = unchecked((int)1),
  /// <summary>
  /// The enclosure is larger.
  /// </summary>
  wdEncloseStyleLarge = unchecked((int)2)
}
