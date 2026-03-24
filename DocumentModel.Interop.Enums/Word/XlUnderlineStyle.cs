namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline applied to a font.
/// </summary>
public enum XlUnderlineStyle
{
  /// <summary>
  /// Single underlining.
  /// </summary>
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  SingleAccounting = 4,
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  DoubleAccounting = 5,
  /// <summary>
  /// Specifies the type of underline applied to a font.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Specifies the type of underline applied to a font.
  /// </summary>
  Double = -4119
}
