namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlUnderlineStyle")]
public enum UnderlineStyle
{
  /// <summary>
  /// Single underlining.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleSingle")]
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleSingleAccounting")]
  SingleAccounting = 4,
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleDoubleAccounting")]
  DoubleAccounting = 5,
  /// <summary>
  /// No underlining.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleNone")]
  None = -4142,
  /// <summary>
  /// Double thick underline.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleDouble")]
  Double = -4119
}

