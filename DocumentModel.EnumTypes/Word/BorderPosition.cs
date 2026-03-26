namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of border to be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbordertype?view=office-pia` for Office interop details.
/// </remarks>
public enum BorderPosition
{
  /// <summary>
  /// A diagonal border starting in the bottom left corner.
  /// </summary>
  DiagonalUp = -8,
  /// <summary>
  /// A diagonal border starting in the top left corner.
  /// </summary>
  DiagonalDown = -7,
  /// <summary>
  /// Vertical borders.
  /// </summary>
  Vertical = -6,
  /// <summary>
  /// Horizontal borders.
  /// </summary>
  Horizontal = -5,
  /// <summary>
  /// A right border.
  /// </summary>
  Right = -4,
  /// <summary>
  /// A bottom border.
  /// </summary>
  Bottom = -3,
  /// <summary>
  /// A left border.
  /// </summary>
  Left = -2,
  /// <summary>
  /// A top border.
  /// </summary>
  Top = -1
}
