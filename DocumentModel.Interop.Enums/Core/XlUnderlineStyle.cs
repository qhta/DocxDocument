
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlUnderlineStyle")]
public enum UnderlineStyle
{
  /// <summary>
  /// Double thick underline.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleDouble")]
  Double = -4119,
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
  /// Single underlining.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleSingle")]
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("xlUnderlineStyleSingleAccounting")]
  SingleAccounting = 4
}
