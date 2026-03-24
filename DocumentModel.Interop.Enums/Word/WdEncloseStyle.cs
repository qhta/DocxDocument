namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative size of an enclosure.
/// </summary>
public enum WdEncloseStyle
{
  /// <summary>
  /// The enclosure assumes the default size.
  /// </summary>
  None = 0,
  /// <summary>
  /// The enclosure is smaller.
  /// </summary>
  Small = 1,
  /// <summary>
  /// The enclosure is larger.
  /// </summary>
  Large = 2
}
