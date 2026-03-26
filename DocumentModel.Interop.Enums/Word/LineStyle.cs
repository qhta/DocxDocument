namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinestyle?view=office-pia` for Office interop details.
/// </remarks>
public enum LineStyle
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
  /// An internal single thin solid line surrounded by a single thick solid line with a small gap between them.
  /// </summary>
  ThinThickSmallGap = 9,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a small gap between them.
  /// </summary>
  ThickThinSmallGap = 10,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a small gap between all lines.
  /// </summary>
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  ThinThickMedGap = 12,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// </summary>
  ThickThinMedGap = 13,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a medium gap between all lines.
  /// </summary>
  ThinThickThinMedGap = 14,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// </summary>
  ThinThickLargeGap = 15,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a large gap between them.
  /// </summary>
  ThickThinLargeGap = 16,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a large gap between all lines.
  /// </summary>
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  SingleWavy = 18,
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  DoubleWavy = 19,
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  DashDotStroked = 20,
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  Emboss3D = 21,
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  Engrave3D = 22,
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  Outset = 23,
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  Inset = 24
}
