namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlTickMark")]
public enum TickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  [InteropEnumValue("xlTickMarkInside")]
  Inside = 2,
  /// <summary>
  /// No mark
  /// </summary>
  [InteropEnumValue("xlTickMarkOutside")]
  Outside = 3,
  /// <summary>
  /// Crosses the axis
  /// </summary>
  [InteropEnumValue("xlTickMarkCross")]
  Cross = 4,
  /// <summary>
  /// No mark.
  /// </summary>
  [InteropEnumValue("xlTickMarkNone")]
  None = -4142
}

