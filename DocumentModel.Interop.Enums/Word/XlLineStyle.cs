namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line style for the border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllinestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.XlLineStyle))]
public enum XlLineStyle
{
  /// <summary>
  /// Continuous line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlContinuous))]
  Continuous = 1,
  /// <summary>
  /// Alternating dashes and dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlDashDot))]
  DashDot = 4,
  /// <summary>
  /// Dash followed by two dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlDashDotDot))]
  DashDotDot = 5,
  /// <summary>
  /// Slanted dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlSlantDashDot))]
  SlantDashDot = 13,
  /// <summary>
  /// No line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlLineStyleNone))]
  LineStyleNone = -4142,
  /// <summary>
  /// Double line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlDouble))]
  Double = -4119,
  /// <summary>
  /// Dotted line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlDot))]
  Dot = -4118,
  /// <summary>
  /// Dashed line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.XlLineStyle.xlDash))]
  Dash = -4115
}
