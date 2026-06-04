namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunderline?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdUnderline")]
public enum Underline
{
  /// <summary>
  /// No underline.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineNone")]
  None = 0,
  /// <summary>
  /// A single line. default.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineSingle")]
  Single = 1,
  /// <summary>
  /// Underline individual words only.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineWords")]
  Words = 2,
  /// <summary>
  /// A double line.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDouble")]
  Double = 3,
  /// <summary>
  /// Dots.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDotted")]
  Dotted = 4,
  /// <summary>
  /// A single thick line.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineThick")]
  Thick = 6,
  /// <summary>
  /// Dashes.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDash")]
  Dash = 7,
  /// <summary>
  /// Alternating dots and dashes.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDotDash")]
  DotDash = 9,
  /// <summary>
  /// An alternating dot-dot-dash pattern.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDotDotDash")]
  DotDotDash = 10,
  /// <summary>
  /// A single wavy line.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineWavy")]
  Wavy = 11,
  /// <summary>
  /// Heavy dots.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDottedHeavy")]
  DottedHeavy = 20,
  /// <summary>
  /// Heavy dashes.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDashHeavy")]
  DashHeavy = 23,
  /// <summary>
  /// Alternating heavy dots and heavy dashes.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDotDashHeavy")]
  DotDashHeavy = 25,
  /// <summary>
  /// An alternating heavy dot-dot-dash pattern.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDotDotDashHeavy")]
  DotDotDashHeavy = 26,
  /// <summary>
  /// A heavy wavy line.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineWavyHeavy")]
  WavyHeavy = 27,
  /// <summary>
  /// Long dashes.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDashLong")]
  DashLong = 39,
  /// <summary>
  /// A double wavy line.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineWavyDouble")]
  WavyDouble = 43,
  /// <summary>
  /// Long heavy dashes.
  /// </summary>
  [WordInteropEnumValue("wdUnderlineDashLongHeavy")]
  DashLongHeavy = 55
}
