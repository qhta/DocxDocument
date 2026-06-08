
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.XlHAlign")]
public enum HAlign
{
  /// <summary>
  /// Center.
  /// </summary>
  [InteropEnumValue("xlHAlignCenter")]
  Center = -4108,
  /// <summary>
  /// Center across selection.
  /// </summary>
  [InteropEnumValue("xlHAlignCenterAcrossSelection")]
  CenterAcrossSelection = 7,
  /// <summary>
  /// Distribute.
  /// </summary>
  [InteropEnumValue("xlHAlignDistributed")]
  Distributed = -4117,
  /// <summary>
  /// Fill.
  /// </summary>
  [InteropEnumValue("xlHAlignFill")]
  Fill = 5,
  /// <summary>
  /// Align according to data type.
  /// </summary>
  [InteropEnumValue("xlHAlignGeneral")]
  General = 1,
  /// <summary>
  /// Justify.
  /// </summary>
  [InteropEnumValue("xlHAlignJustify")]
  Justify = -4130,
  /// <summary>
  /// Left.
  /// </summary>
  [InteropEnumValue("xlHAlignLeft")]
  Left = -4131,
  /// <summary>
  /// Right.
  /// </summary>
  [InteropEnumValue("xlHAlignRight")]
  Right = -4152
}
