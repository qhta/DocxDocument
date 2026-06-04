namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunderline?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdUnderline")]
public enum Underline
{
  /// <summary>
  /// No underline.
  /// </summary>
  [InteropEnumValue("wdUnderlineNone")]
  None = 0,
  /// <summary>
  /// A single line. default.
  /// </summary>
  [InteropEnumValue("wdUnderlineSingle")]
  Single = 1,
  /// <summary>
  /// Underline individual words only.
  /// </summary>
  [InteropEnumValue("wdUnderlineWords")]
  Words = 2,
  /// <summary>
  /// A double line.
  /// </summary>
  [InteropEnumValue("wdUnderlineDouble")]
  Double = 3,
  /// <summary>
  /// Dots.
  /// </summary>
  [InteropEnumValue("wdUnderlineDotted")]
  Dotted = 4,
  /// <summary>
  /// A single thick line.
  /// </summary>
  [InteropEnumValue("wdUnderlineThick")]
  Thick = 6,
  /// <summary>
  /// Dashes.
  /// </summary>
  [InteropEnumValue("wdUnderlineDash")]
  Dash = 7,
  /// <summary>
  /// Alternating dots and dashes.
  /// </summary>
  [InteropEnumValue("wdUnderlineDotDash")]
  DotDash = 9,
  /// <summary>
  /// An alternating dot-dot-dash pattern.
  /// </summary>
  [InteropEnumValue("wdUnderlineDotDotDash")]
  DotDotDash = 10,
  /// <summary>
  /// A single wavy line.
  /// </summary>
  [InteropEnumValue("wdUnderlineWavy")]
  Wavy = 11,
  /// <summary>
  /// Heavy dots.
  /// </summary>
  [InteropEnumValue("wdUnderlineDottedHeavy")]
  DottedHeavy = 20,
  /// <summary>
  /// Heavy dashes.
  /// </summary>
  [InteropEnumValue("wdUnderlineDashHeavy")]
  DashHeavy = 23,
  /// <summary>
  /// Alternating heavy dots and heavy dashes.
  /// </summary>
  [InteropEnumValue("wdUnderlineDotDashHeavy")]
  DotDashHeavy = 25,
  /// <summary>
  /// An alternating heavy dot-dot-dash pattern.
  /// </summary>
  [InteropEnumValue("wdUnderlineDotDotDashHeavy")]
  DotDotDashHeavy = 26,
  /// <summary>
  /// A heavy wavy line.
  /// </summary>
  [InteropEnumValue("wdUnderlineWavyHeavy")]
  WavyHeavy = 27,
  /// <summary>
  /// Long dashes.
  /// </summary>
  [InteropEnumValue("wdUnderlineDashLong")]
  DashLong = 39,
  /// <summary>
  /// A double wavy line.
  /// </summary>
  [InteropEnumValue("wdUnderlineWavyDouble")]
  WavyDouble = 43,
  /// <summary>
  /// Long heavy dashes.
  /// </summary>
  [InteropEnumValue("wdUnderlineDashLongHeavy")]
  DashLongHeavy = 55
}
