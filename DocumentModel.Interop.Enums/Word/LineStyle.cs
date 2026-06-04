namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLineStyle))]
public enum LineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone))]
  None = 0,
  /// <summary>
  /// A single solid line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle))]
  Single = 1,
  /// <summary>
  /// Dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDot))]
  Dot = 2,
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDashSmallGap))]
  DashSmallGap = 3,
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDashLargeGap))]
  DashLargeGap = 4,
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDashDot))]
  DashDot = 5,
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDashDotDot))]
  DashDotDot = 6,
  /// <summary>
  /// Double solid lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble))]
  Double = 7,
  /// <summary>
  /// Three solid thin lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleTriple))]
  Triple = 8,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a small gap between them.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickSmallGap))]
  ThinThickSmallGap = 9,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a small gap between them.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThickThinSmallGap))]
  ThickThinSmallGap = 10,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a small gap between all lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickThinSmallGap))]
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickMedGap))]
  ThinThickMedGap = 12,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThickThinMedGap))]
  ThickThinMedGap = 13,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a medium gap between all lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickThinMedGap))]
  ThinThickThinMedGap = 14,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickLargeGap))]
  ThinThickLargeGap = 15,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a large gap between them.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThickThinLargeGap))]
  ThickThinLargeGap = 16,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a large gap between all lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleThinThickThinLargeGap))]
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingleWavy))]
  SingleWavy = 18,
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDoubleWavy))]
  DoubleWavy = 19,
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDashDotStroked))]
  DashDotStroked = 20,
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleEmboss3D))]
  Emboss3D = 21,
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleEngrave3D))]
  Engrave3D = 22,
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleOutset))]
  Outset = 23,
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleInset))]
  Inset = 24
}
