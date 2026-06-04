
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlVAlign")]
public enum VAlign
{
  /// <summary>
  /// Bottom
  /// </summary>
  [OfficeInteropEnumValue("xlVAlignBottom")]
  Bottom = -4107,
  /// <summary>
  /// Center
  /// </summary>
  [OfficeInteropEnumValue("xlVAlignCenter")]
  Center = -4108,
  /// <summary>
  /// Distributed
  /// </summary>
  [OfficeInteropEnumValue("xlVAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Justify
  /// </summary>
  [OfficeInteropEnumValue("xlVAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Top
  /// </summary>
  [OfficeInteropEnumValue("xlVAlignTop")]
  Top = -4160
}
