namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinestyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  None = 0,
  /// <summary>
  /// A single solid line.
  /// </summary>
  Single = 1,
  /// <summary>
  /// Dots.
  /// </summary>
  Dot = 2,
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  DashSmallGap = 3,
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  DashLargeGap = 4,
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  DashDot = 5,
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  DashDotDot = 6,
  /// <summary>
  /// Double solid lines.
  /// </summary>
  Double = 7,
  /// <summary>
  /// Three solid thin lines.
  /// </summary>
  Triple = 8,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickSmallGap = 9,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinSmallGap = 10,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickMedGap = 12,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinMedGap = 13,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinMedGap = 14,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickLargeGap = 15,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThickThinLargeGap = 16,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  SingleWavy = 18,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  DoubleWavy = 19,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  DashDotStroked = 20,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  Emboss3D = 21,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  Engrave3D = 22,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  Outset = 23,
  /// <summary>
  /// Specifies the border style for an object.
  /// </summary>
  Inset = 24
}
