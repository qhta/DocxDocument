
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the type
/// of underline applied to a font.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlunderlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlUnderlineStyle))]
public enum UnderlineStyle
{
  /// <summary>
  /// Double thick underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlUnderlineStyle.xlUnderlineStyleDouble))]
  Double = -4119,
  /// <summary>
  /// Two thin underlines placed close together.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlUnderlineStyle.xlUnderlineStyleDoubleAccounting))]
  DoubleAccounting = 5,
  /// <summary>
  /// No underlining.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlUnderlineStyle.xlUnderlineStyleNone))]
  None = -4142,
  /// <summary>
  /// Single underlining.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlUnderlineStyle.xlUnderlineStyleSingle))]
  Single = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlUnderlineStyle.xlUnderlineStyleSingleAccounting))]
  SingleAccounting = 4
}
