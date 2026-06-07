namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line style for the border.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xllinestyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.XlLineStyle")]
public enum XlLineStyle
{
  /// <summary>
  /// Continuous line.
  /// </summary>
  [InteropEnumValue("xlContinuous")]
  Continuous = 1,
  /// <summary>
  /// Alternating dashes and dots.
  /// </summary>
  [InteropEnumValue("xlDashDot")]
  DashDot = 4,
  /// <summary>
  /// Dash followed by two dots.
  /// </summary>
  [InteropEnumValue("xlDashDotDot")]
  DashDotDot = 5,
  /// <summary>
  /// Slanted dashes.
  /// </summary>
  [InteropEnumValue("xlSlantDashDot")]
  SlantDashDot = 13,
  /// <summary>
  /// No line.
  /// </summary>
  [InteropEnumValue("xlLineStyleNone")]
  LineStyleNone = -4142,
  /// <summary>
  /// Double line.
  /// </summary>
  [InteropEnumValue("xlDouble")]
  Double = -4119,
  /// <summary>
  /// Dotted line.
  /// </summary>
  [InteropEnumValue("xlDot")]
  Dot = -4118,
  /// <summary>
  /// Dashed line.
  /// </summary>
  [InteropEnumValue("xlDash")]
  Dash = -4115
}
