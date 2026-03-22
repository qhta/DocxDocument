namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number form setting for an OpenType font.
/// </summary>
public enum WdNumberForm
{
  /// <summary>
  /// Applies the default number form for the font.
  /// </summary>
  wdNumberFormDefault = unchecked((int)0),
  /// <summary>
  /// Applies the lining number form to the font.
  /// </summary>
  wdNumberFormLining = unchecked((int)1),
  /// <summary>
  /// Applies the "old-style" number form to the font.
  /// </summary>
  wdNumberFormOldStyle = unchecked((int)2)
}
