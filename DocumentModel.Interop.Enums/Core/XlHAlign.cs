
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies the
/// horizontal alignment for the object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xlhalign?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.XlHAlign))]
public enum HAlign
{
  /// <summary>
  /// Center.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignCenter))]
  Center = -4108,
  /// <summary>
  /// Center across selection.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignCenterAcrossSelection))]
  CenterAcrossSelection = 7,
  /// <summary>
  /// Distribute.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignDistributed))]
  Distributed = -4117,
  /// <summary>
  /// Fill.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignFill))]
  Fill = 5,
  /// <summary>
  /// Align according to data type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignGeneral))]
  General = 1,
  /// <summary>
  /// Justify.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignJustify))]
  Justify = -4130,
  /// <summary>
  /// Left.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignLeft))]
  Left = -4131,
  /// <summary>
  /// Right.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.XlHAlign.xlHAlignRight))]
  Right = -4152
}
