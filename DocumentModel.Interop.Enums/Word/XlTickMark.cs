namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of major and minor tick marks for an axis.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltickmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlTickMark))]
public enum TickMark
{
  /// <summary>
  /// Inside the axis
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickMark.xlTickMarkInside))]
  Inside = 2,
  /// <summary>
  /// No mark
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickMark.xlTickMarkOutside))]
  Outside = 3,
  /// <summary>
  /// Crosses the axis
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickMark.xlTickMarkCross))]
  Cross = 4,
  /// <summary>
  /// No mark.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlTickMark.xlTickMarkNone))]
  None = -4142
}
