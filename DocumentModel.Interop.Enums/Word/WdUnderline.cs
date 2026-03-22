namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline to apply.
/// </summary>
public enum WdUnderline
{
  /// <summary>
  /// No underline.
  /// </summary>
  wdUnderlineNone = unchecked((int)0),
  /// <summary>
  /// A single line. default.
  /// </summary>
  wdUnderlineSingle = unchecked((int)1),
  /// <summary>
  /// Underline individual words only.
  /// </summary>
  wdUnderlineWords = unchecked((int)2),
  /// <summary>
  /// A double line.
  /// </summary>
  wdUnderlineDouble = unchecked((int)3),
  /// <summary>
  /// Dots.
  /// </summary>
  wdUnderlineDotted = unchecked((int)4),
  /// <summary>
  /// A single thick line.
  /// </summary>
  wdUnderlineThick = unchecked((int)6),
  /// <summary>
  /// Dashes.
  /// </summary>
  wdUnderlineDash = unchecked((int)7),
  /// <summary>
  /// Alternating dots and dashes.
  /// </summary>
  wdUnderlineDotDash = unchecked((int)9),
  /// <summary>
  /// An alternating dot-dot-dash pattern.
  /// </summary>
  wdUnderlineDotDotDash = unchecked((int)10),
  /// <summary>
  /// A single wavy line.
  /// </summary>
  wdUnderlineWavy = unchecked((int)11),
  /// <summary>
  /// Heavy dots. [System.Runtime.InteropServices.Guid("DA77B198-31E3-312B-83EB-A0CFD52B0085")] public enum
  /// WdUnderline ﾉ Expand table
  /// </summary>
  wdUnderlineDottedHeavy = unchecked((int)20),
  /// <summary>
  /// Heavy dashes.
  /// </summary>
  wdUnderlineDashHeavy = unchecked((int)23),
  /// <summary>
  /// Alternating heavy dots and heavy dashes. wdUnderlineDotDotDashHeavy26 An alternating heavy dot-dot-dash
  /// pattern.
  /// </summary>
  wdUnderlineDotDashHeavy = unchecked((int)25),
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  wdUnderlineDotDotDashHeavy = unchecked((int)26),
  /// <summary>
  /// A heavy wavy line.
  /// </summary>
  wdUnderlineWavyHeavy = unchecked((int)27),
  /// <summary>
  /// Long dashes.
  /// </summary>
  wdUnderlineDashLong = unchecked((int)39),
  /// <summary>
  /// A double wavy line.
  /// </summary>
  wdUnderlineWavyDouble = unchecked((int)43),
  /// <summary>
  /// Long heavy dashes.
  /// </summary>
  wdUnderlineDashLongHeavy = unchecked((int)55)
}
