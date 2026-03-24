namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number form setting for an OpenType font.
/// </summary>
public enum WdNumberForm
{
  /// <summary>
  /// Applies the default number form for the font.
  /// </summary>
  Default = 0,
  /// <summary>
  /// Applies the lining number form to the font.
  /// </summary>
  Lining = 1,
  /// <summary>
  /// Applies the "old-style" number form to the font.
  /// </summary>
  OldStyle = 2
}
