namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLineStyle")]
public enum LineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  [InteropEnumValue("wdLineStyleNone")]
  None = 0,
  /// <summary>
  /// A single solid line.
  /// </summary>
  [InteropEnumValue("wdLineStyleSingle")]
  Single = 1,
  /// <summary>
  /// Dots.
  /// </summary>
  [InteropEnumValue("wdLineStyleDot")]
  Dot = 2,
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  [InteropEnumValue("wdLineStyleDashSmallGap")]
  DashSmallGap = 3,
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  [InteropEnumValue("wdLineStyleDashLargeGap")]
  DashLargeGap = 4,
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  [InteropEnumValue("wdLineStyleDashDot")]
  DashDot = 5,
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  [InteropEnumValue("wdLineStyleDashDotDot")]
  DashDotDot = 6,
  /// <summary>
  /// Double solid lines.
  /// </summary>
  [InteropEnumValue("wdLineStyleDouble")]
  Double = 7,
  /// <summary>
  /// Three solid thin lines.
  /// </summary>
  [InteropEnumValue("wdLineStyleTriple")]
  Triple = 8,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a small gap between them.
  /// </summary>
  [InteropEnumValue("wdLineStyleThinThickSmallGap")]
  ThinThickSmallGap = 9,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a small gap between them.
  /// </summary>
  [InteropEnumValue("wdLineStyleThickThinSmallGap")]
  ThickThinSmallGap = 10,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a small gap between all lines.
  /// </summary>
  [InteropEnumValue("wdLineStyleThinThickThinSmallGap")]
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  [InteropEnumValue("wdLineStyleThinThickMedGap")]
  ThinThickMedGap = 12,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// </summary>
  [InteropEnumValue("wdLineStyleThickThinMedGap")]
  ThickThinMedGap = 13,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a medium gap between all lines.
  /// </summary>
  [InteropEnumValue("wdLineStyleThinThickThinMedGap")]
  ThinThickThinMedGap = 14,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// </summary>
  [InteropEnumValue("wdLineStyleThinThickLargeGap")]
  ThinThickLargeGap = 15,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a large gap between them.
  /// </summary>
  [InteropEnumValue("wdLineStyleThickThinLargeGap")]
  ThickThinLargeGap = 16,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a large gap between all lines.
  /// </summary>
  [InteropEnumValue("wdLineStyleThinThickThinLargeGap")]
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  [InteropEnumValue("wdLineStyleSingleWavy")]
  SingleWavy = 18,
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  [InteropEnumValue("wdLineStyleDoubleWavy")]
  DoubleWavy = 19,
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  [InteropEnumValue("wdLineStyleDashDotStroked")]
  DashDotStroked = 20,
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  [InteropEnumValue("wdLineStyleEmboss3D")]
  Emboss3D = 21,
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  [InteropEnumValue("wdLineStyleEngrave3D")]
  Engrave3D = 22,
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  [InteropEnumValue("wdLineStyleOutset")]
  Outset = 23,
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  [InteropEnumValue("wdLineStyleInset")]
  Inset = 24
}
