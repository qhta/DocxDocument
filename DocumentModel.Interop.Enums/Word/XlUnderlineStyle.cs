namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlUnderlineStyle))]
public enum UnderlineStyle
{
  /// <summary>
  /// Single underlining.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlUnderlineStyle.xlUnderlineStyleSingle))]
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlUnderlineStyle.xlUnderlineStyleSingleAccounting))]
  SingleAccounting = 4,
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlUnderlineStyle.xlUnderlineStyleDoubleAccounting))]
  DoubleAccounting = 5,
  /// <summary>
  /// No underlining.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlUnderlineStyle.xlUnderlineStyleNone))]
  None = -4142,
  /// <summary>
  /// Double thick underline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlUnderlineStyle.xlUnderlineStyleDouble))]
  Double = -4119
}
