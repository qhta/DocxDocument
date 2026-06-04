
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlUnderlineStyle")]
public enum UnderlineStyle
{
  /// <summary>
  /// Double thick underline.
  /// </summary>
  [OfficeInteropEnumValue("xlUnderlineStyleDouble")]
  Double = -4119,
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  [OfficeInteropEnumValue("xlUnderlineStyleDoubleAccounting")]
  DoubleAccounting = 5,
  /// <summary>
  /// No underlining.
  /// </summary>
  [OfficeInteropEnumValue("xlUnderlineStyleNone")]
  None = -4142,
  /// <summary>
  /// Single underlining.
  /// </summary>
  [OfficeInteropEnumValue("xlUnderlineStyleSingle")]
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue("xlUnderlineStyleSingleAccounting")]
  SingleAccounting = 4
}
