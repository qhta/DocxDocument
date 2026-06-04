namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunderline?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdUnderline))]
public enum Underline
{
  /// <summary>
  /// No underline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineNone))]
  None = 0,
  /// <summary>
  /// A single line. default.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineSingle))]
  Single = 1,
  /// <summary>
  /// Underline individual words only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineWords))]
  Words = 2,
  /// <summary>
  /// A double line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDouble))]
  Double = 3,
  /// <summary>
  /// Dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDotted))]
  Dotted = 4,
  /// <summary>
  /// A single thick line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineThick))]
  Thick = 6,
  /// <summary>
  /// Dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDash))]
  Dash = 7,
  /// <summary>
  /// Alternating dots and dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDotDash))]
  DotDash = 9,
  /// <summary>
  /// An alternating dot-dot-dash pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDotDotDash))]
  DotDotDash = 10,
  /// <summary>
  /// A single wavy line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineWavy))]
  Wavy = 11,
  /// <summary>
  /// Heavy dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDottedHeavy))]
  DottedHeavy = 20,
  /// <summary>
  /// Heavy dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDashHeavy))]
  DashHeavy = 23,
  /// <summary>
  /// Alternating heavy dots and heavy dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDotDashHeavy))]
  DotDashHeavy = 25,
  /// <summary>
  /// An alternating heavy dot-dot-dash pattern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDotDotDashHeavy))]
  DotDotDashHeavy = 26,
  /// <summary>
  /// A heavy wavy line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineWavyHeavy))]
  WavyHeavy = 27,
  /// <summary>
  /// Long dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDashLong))]
  DashLong = 39,
  /// <summary>
  /// A double wavy line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineWavyDouble))]
  WavyDouble = 43,
  /// <summary>
  /// Long heavy dashes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdUnderline.wdUnderlineDashLongHeavy))]
  DashLongHeavy = 55
}
