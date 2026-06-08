
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// vertical alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlvalign?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlVAlign")]
public enum VAlign
{
  /// <summary>
  /// Bottom
  /// </summary>
  [InteropEnumValue("xlVAlignBottom")]
  Bottom = -4107,
  /// <summary>
  /// Center
  /// </summary>
  [InteropEnumValue("xlVAlignCenter")]
  Center = -4108,
  /// <summary>
  /// Distributed
  /// </summary>
  [InteropEnumValue("xlVAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Justify
  /// </summary>
  [InteropEnumValue("xlVAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Top
  /// </summary>
  [InteropEnumValue("xlVAlignTop")]
  Top = -4160
}
