namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of border to be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbordertype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBorderType")]
public enum BorderType
{
  /// <summary>
  /// A diagonal border starting in the bottom left corner.
  /// </summary>
  [WordInteropEnumValue("wdBorderDiagonalUp")]
  DiagonalUp = -8,
  /// <summary>
  /// A diagonal border starting in the top left corner.
  /// </summary>
  [WordInteropEnumValue("wdBorderDiagonalDown")]
  DiagonalDown = -7,
  /// <summary>
  /// Vertical borders.
  /// </summary>
  [WordInteropEnumValue("wdBorderVertical")]
  Vertical = -6,
  /// <summary>
  /// Horizontal borders.
  /// </summary>
  [WordInteropEnumValue("wdBorderHorizontal")]
  Horizontal = -5,
  /// <summary>
  /// A right border.
  /// </summary>
  [WordInteropEnumValue("wdBorderRight")]
  Right = -4,
  /// <summary>
  /// A bottom border.
  /// </summary>
  [WordInteropEnumValue("wdBorderBottom")]
  Bottom = -3,
  /// <summary>
  /// A left border.
  /// </summary>
  [WordInteropEnumValue("wdBorderLeft")]
  Left = -2,
  /// <summary>
  /// A top border.
  /// </summary>
  [WordInteropEnumValue("wdBorderTop")]
  Top = -1
}
