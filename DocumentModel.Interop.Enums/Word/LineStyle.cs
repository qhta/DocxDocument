namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLineStyle")]
public enum LineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleNone")]
  None = 0,
  /// <summary>
  /// A single solid line.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleSingle")]
  Single = 1,
  /// <summary>
  /// Dots.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDot")]
  Dot = 2,
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDashSmallGap")]
  DashSmallGap = 3,
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDashLargeGap")]
  DashLargeGap = 4,
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDashDot")]
  DashDot = 5,
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDashDotDot")]
  DashDotDot = 6,
  /// <summary>
  /// Double solid lines.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDouble")]
  Double = 7,
  /// <summary>
  /// Three solid thin lines.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleTriple")]
  Triple = 8,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a small gap between them.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThinThickSmallGap")]
  ThinThickSmallGap = 9,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a small gap between them.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThickThinSmallGap")]
  ThickThinSmallGap = 10,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a small gap between all lines.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThinThickThinSmallGap")]
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThinThickMedGap")]
  ThinThickMedGap = 12,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThickThinMedGap")]
  ThickThinMedGap = 13,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a medium gap between all lines.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThinThickThinMedGap")]
  ThinThickThinMedGap = 14,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThinThickLargeGap")]
  ThinThickLargeGap = 15,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a large gap between them.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThickThinLargeGap")]
  ThickThinLargeGap = 16,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a large gap between all lines.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleThinThickThinLargeGap")]
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleSingleWavy")]
  SingleWavy = 18,
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDoubleWavy")]
  DoubleWavy = 19,
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleDashDotStroked")]
  DashDotStroked = 20,
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleEmboss3D")]
  Emboss3D = 21,
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleEngrave3D")]
  Engrave3D = 22,
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleOutset")]
  Outset = 23,
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  [WordInteropEnumValue("wdLineStyleInset")]
  Inset = 24
}
