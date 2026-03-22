namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline applied to a font.
/// </summary>
public enum XlUnderlineStyle
{
  /// <summary>
  /// Single underlining.
  /// </summary>
  xlUnderlineStyleSingle = unchecked((int)2),
  /// <summary>
  /// Not supported.
  /// </summary>
  xlUnderlineStyleSingleAccounting = unchecked((int)4),
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  xlUnderlineStyleDoubleAccounting = unchecked((int)5),
  /// <summary>
  /// Specifies the type of underline applied to a font.
  /// </summary>
  xlUnderlineStyleNone = unchecked((int)-4142),
  /// <summary>
  /// Specifies the type of underline applied to a font.
  /// </summary>
  xlUnderlineStyleDouble = unchecked((int)-4119)
}
