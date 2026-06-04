namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of border to be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbordertype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBorderType))]
public enum BorderType
{
  /// <summary>
  /// A diagonal border starting in the bottom left corner.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderDiagonalUp))]
  DiagonalUp = -8,
  /// <summary>
  /// A diagonal border starting in the top left corner.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderDiagonalDown))]
  DiagonalDown = -7,
  /// <summary>
  /// Vertical borders.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderVertical))]
  Vertical = -6,
  /// <summary>
  /// Horizontal borders.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderHorizontal))]
  Horizontal = -5,
  /// <summary>
  /// A right border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight))]
  Right = -4,
  /// <summary>
  /// A bottom border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderBottom))]
  Bottom = -3,
  /// <summary>
  /// A left border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft))]
  Left = -2,
  /// <summary>
  /// A top border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderType.wdBorderTop))]
  Top = -1
}
