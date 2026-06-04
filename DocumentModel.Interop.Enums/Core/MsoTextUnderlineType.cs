namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the type of underline for text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextunderlinetype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoTextUnderlineType")]
public enum TextUnderlineType
{
  /// <summary>
  /// Specifies a mix of underline types.
  /// </summary>
  [InteropEnumValue("msoUnderlineMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies no underline.
  /// </summary>
  [InteropEnumValue("msoNoUnderline")]
  NoUnderline = 0,
  /// <summary>
  /// Specifies underlining words.
  /// </summary>
  [InteropEnumValue("msoUnderlineWords")]
  Words = 1,
  /// <summary>
  /// Specifies a single line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineSingleLine")]
  SingleLine = 2,
  /// <summary>
  /// Specifies a double line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDoubleLine")]
  DoubleLine = 3,
  /// <summary>
  /// Specifies a heavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineHeavyLine")]
  HeavyLine = 4,
  /// <summary>
  /// Specifies a dotted line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDottedLine")]
  DottedLine = 5,
  /// <summary>
  /// Specifies a dotted heavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDottedHeavyLine")]
  DottedHeavyLine = 6,
  /// <summary>
  /// Specifies a dash line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDashLine")]
  DashLine = 7,
  /// <summary>
  /// Specifies a dash underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDashHeavyLine")]
  DashHeavyLine = 8,
  /// <summary>
  /// Specifies a dashed long line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDashLongLine")]
  DashLongLine = 9,
  /// <summary>
  /// Specifies a long heavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDashLongHeavyLine")]
  DashLongHeavyLine = 10,
  /// <summary>
  /// Specifies a dot dash line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDotDashLine")]
  DotDashLine = 11,
  /// <summary>
  /// Specifies a dot dash heavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDotDashHeavyLine")]
  DotDashHeavyLine = 12,
  /// <summary>
  /// Specifies a dot dot dash line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDotDotDashLine")]
  DotDotDashLine = 13,
  /// <summary>
  /// Specifies a dot dot dash heavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineDotDotDashHeavyLine")]
  DotDotDashHeavyLine = 14,
  /// <summary>
  /// Specifies a wavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineWavyLine")]
  WavyLine = 15,
  /// <summary>
  /// Specifies a wavy heavy line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineWavyHeavyLine")]
  WavyHeavyLine = 16,
  /// <summary>
  /// Specifies a wavy double line underline.
  /// </summary>
  [InteropEnumValue("msoUnderlineWavyDoubleLine")]
  WavyDoubleLine = 17
}
