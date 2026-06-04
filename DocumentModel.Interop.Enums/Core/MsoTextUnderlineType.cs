namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the type of underline for text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msotextunderlinetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoTextUnderlineType))]
public enum TextUnderlineType
{
  /// <summary>
  /// Specifies a mix of underline types.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineMixed))]
  Mixed = -2,
  /// <summary>
  /// Specifies no underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoNoUnderline))]
  NoUnderline = 0,
  /// <summary>
  /// Specifies underlining words.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineWords))]
  Words = 1,
  /// <summary>
  /// Specifies a single line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineSingleLine))]
  SingleLine = 2,
  /// <summary>
  /// Specifies a double line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDoubleLine))]
  DoubleLine = 3,
  /// <summary>
  /// Specifies a heavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineHeavyLine))]
  HeavyLine = 4,
  /// <summary>
  /// Specifies a dotted line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDottedLine))]
  DottedLine = 5,
  /// <summary>
  /// Specifies a dotted heavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDottedHeavyLine))]
  DottedHeavyLine = 6,
  /// <summary>
  /// Specifies a dash line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDashLine))]
  DashLine = 7,
  /// <summary>
  /// Specifies a dash underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDashHeavyLine))]
  DashHeavyLine = 8,
  /// <summary>
  /// Specifies a dashed long line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDashLongLine))]
  DashLongLine = 9,
  /// <summary>
  /// Specifies a long heavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDashLongHeavyLine))]
  DashLongHeavyLine = 10,
  /// <summary>
  /// Specifies a dot dash line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDotDashLine))]
  DotDashLine = 11,
  /// <summary>
  /// Specifies a dot dash heavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDotDashHeavyLine))]
  DotDashHeavyLine = 12,
  /// <summary>
  /// Specifies a dot dot dash line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDotDotDashLine))]
  DotDotDashLine = 13,
  /// <summary>
  /// Specifies a dot dot dash heavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineDotDotDashHeavyLine))]
  DotDotDashHeavyLine = 14,
  /// <summary>
  /// Specifies a wavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineWavyLine))]
  WavyLine = 15,
  /// <summary>
  /// Specifies a wavy heavy line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineWavyHeavyLine))]
  WavyHeavyLine = 16,
  /// <summary>
  /// Specifies a wavy double line underline.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoTextUnderlineType.msoUnderlineWavyDoubleLine))]
  WavyDoubleLine = 17
}
