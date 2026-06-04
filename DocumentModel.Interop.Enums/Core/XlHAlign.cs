
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlHAlign")]
public enum HAlign
{
  /// <summary>
  /// Center.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignCenter")]
  Center = -4108,
  /// <summary>
  /// Center across selection.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignCenterAcrossSelection")]
  CenterAcrossSelection = 7,
  /// <summary>
  /// Distribute.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Fill.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignFill")]
  Fill = 5,
  /// <summary>
  /// Align according to data type.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignGeneral")]
  General = 1,
  /// <summary>
  /// Justify.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Left.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignLeft")]
  Left = -4131,
  /// <summary>
  /// Right.
  /// </summary>
  [OfficeInteropEnumValue("xlHAlignRight")]
  Right = -4152
}
