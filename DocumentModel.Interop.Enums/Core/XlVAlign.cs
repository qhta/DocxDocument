
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlVAlign))]
public enum VAlign
{
  /// <summary>
  /// Bottom
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlVAlign.xlVAlignBottom))]
  Bottom = -4107,
  /// <summary>
  /// Center
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlVAlign.xlVAlignCenter))]
  Center = -4108,
  /// <summary>
  /// Distributed
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlVAlign.xlVAlignDistributed))]
  Distributed = -4117,
  /// <summary>
  /// Justify
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlVAlign.xlVAlignJustify))]
  Justify = -4130,
  /// <summary>
  /// Top
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlVAlign.xlVAlignTop))]
  Top = -4160
}
