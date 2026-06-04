namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of border to be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbordertype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBorderType")]
public enum BorderType
{
  /// <summary>
  /// A diagonal border starting in the bottom left corner.
  /// </summary>
  [InteropEnumValue("wdBorderDiagonalUp")]
  DiagonalUp = -8,
  /// <summary>
  /// A diagonal border starting in the top left corner.
  /// </summary>
  [InteropEnumValue("wdBorderDiagonalDown")]
  DiagonalDown = -7,
  /// <summary>
  /// Vertical borders.
  /// </summary>
  [InteropEnumValue("wdBorderVertical")]
  Vertical = -6,
  /// <summary>
  /// Horizontal borders.
  /// </summary>
  [InteropEnumValue("wdBorderHorizontal")]
  Horizontal = -5,
  /// <summary>
  /// A right border.
  /// </summary>
  [InteropEnumValue("wdBorderRight")]
  Right = -4,
  /// <summary>
  /// A bottom border.
  /// </summary>
  [InteropEnumValue("wdBorderBottom")]
  Bottom = -3,
  /// <summary>
  /// A left border.
  /// </summary>
  [InteropEnumValue("wdBorderLeft")]
  Left = -2,
  /// <summary>
  /// A top border.
  /// </summary>
  [InteropEnumValue("wdBorderTop")]
  Top = -1
}
