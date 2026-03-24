namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
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
  /// No underlining.
  /// </summary>
  None = -4142,
  /// <summary>
  /// Double thick underline.
  /// </summary>
  Double = -4119
}
