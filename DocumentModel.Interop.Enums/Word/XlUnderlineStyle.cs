namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline applied to a font.
/// </summary>
public enum XlUnderlineStyle
{
  /// <summary>
  /// Single underlining.
  /// </summary>
  Single = unchecked((int)2),
  /// <summary>
  /// Not supported.
  /// </summary>
  SingleAccounting = unchecked((int)4),
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  DoubleAccounting = unchecked((int)5),
  /// <summary>
  /// Specifies the type of underline applied to a font.
  /// </summary>
  None = unchecked((int)-4142),
  /// <summary>
  /// Specifies the type of underline applied to a font.
  /// </summary>
  Double = unchecked((int)-4119)
}
