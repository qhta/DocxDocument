namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlTickMark")]
public enum TickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  [WordInteropEnumValue("xlTickMarkInside")]
  Inside = 2,
  /// <summary>
  /// No mark
  /// </summary>
  [WordInteropEnumValue("xlTickMarkOutside")]
  Outside = 3,
  /// <summary>
  /// Crosses the axis
  /// </summary>
  [WordInteropEnumValue("xlTickMarkCross")]
  Cross = 4,
  /// <summary>
  /// No mark.
  /// </summary>
  [WordInteropEnumValue("xlTickMarkNone")]
  None = -4142
}
