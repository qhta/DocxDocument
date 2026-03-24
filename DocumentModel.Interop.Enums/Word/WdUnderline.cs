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
  /// Heavy dots. [System.Runtime.InteropServices.Guid("DA77B198-31E3-312B-83EB-A0CFD52B0085")] public enum
  /// WdUnderline ﾉ Expand table
  /// </summary>
  DottedHeavy = 20,
  /// <summary>
  /// Heavy dashes.
  /// </summary>
  DashHeavy = 23,
  /// <summary>
  /// Alternating heavy dots and heavy dashes. wdUnderlineDotDotDashHeavy26 An alternating heavy dot-dot-dash
  /// pattern.
  /// </summary>
  DotDashHeavy = 25,
  /// <summary>
  /// Specifies the type of underline to apply.
  /// </summary>
  DotDotDashHeavy = 26,
  /// <summary>
  /// A heavy wavy line.
  /// </summary>
  WavyHeavy = 27,
  /// <summary>
  /// Long dashes.
  /// </summary>
  DashLong = 39,
  /// <summary>
  /// A double wavy line.
  /// </summary>
  WavyDouble = 43,
  /// <summary>
  /// Long heavy dashes.
  /// </summary>
  DashLongHeavy = 55
}
