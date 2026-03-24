namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of underline to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunderline?view=office-pia` for Office interop details.
/// </remarks>
public enum WdUnderline
{
  /// <summary>
  /// No underline.
  /// </summary>
  None = 0,
  /// <summary>
  /// A single line. default.
  /// </summary>
  Single = 1,
  /// <summary>
  /// Underline individual words only.
  /// </summary>
  Words = 2,
  /// <summary>
  /// A double line.
  /// </summary>
  Double = 3,
  /// <summary>
  /// Dots.
  /// </summary>
  Dotted = 4,
  /// <summary>
  /// A single thick line.
  /// </summary>
  Thick = 6,
  /// <summary>
  /// Dashes.
  /// </summary>
  Dash = 7,
  /// <summary>
  /// Alternating dots and dashes.
  /// </summary>
  DotDash = 9,
  /// <summary>
  /// An alternating dot-dot-dash pattern.
  /// </summary>
  DotDotDash = 10,
  /// <summary>
  /// A single wavy line.
  /// </summary>
  Wavy = 11,
  /// <summary>
  /// Heavy dots.
  /// </summary>
  DottedHeavy = 20,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  DashHeavy = 23,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  DotDashHeavy = 25,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  DotDotDashHeavy = 26,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  WavyHeavy = 27,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  DashLong = 39,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  WavyDouble = 43,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  DashLongHeavy = 55
}
