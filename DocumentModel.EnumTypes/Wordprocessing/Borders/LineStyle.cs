namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the border style for an object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdlinestyle?view=office-pia` for Office interop details.
/// </remarks>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.BorderValues))]
public enum LineStyle
{
  /// <summary>
  /// No border.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.None))]
  None = 0,
  /// <summary>
  /// A single solid line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Single))]
  Single = 1,
  /// <summary>
  /// Dots.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Dotted))]
  Dot = 2,
  /// <summary>
  /// A dash followed by a small gap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DashSmallGap))]
  DashSmallGap = 3,
  /// <summary>
  /// A dash followed by a large gap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Dashed))]
  DashLargeGap = 4,
  /// <summary>
  /// A dash followed by a dot.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DotDash))]
  DashDot = 5,
  /// <summary>
  /// A dash followed by two dots.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DotDotDash))]
  DashDotDot = 6,
  /// <summary>
  /// Double solid lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Double))]
  Double = 7,
  /// <summary>
  /// Three solid thin lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Triple))]
  Triple = 8,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a small gap between them.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickSmallGap))]
  ThinThickSmallGap = 9,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a small gap between them.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinSmallGap))]
  ThickThinSmallGap = 10,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a small gap between all lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinSmallGap))]
  ThinThickThinSmallGap = 11,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a medium gap between them.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickMediumGap))]
  ThinThickMedGap = 12,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a medium gap between them.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinMediumGap))]
  ThickThinMedGap = 13,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a medium gap between all lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinMediumGap))]
  ThinThickThinMedGap = 14,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line with a large gap between them.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickLargeGap))]
  ThinThickLargeGap = 15,
  /// <summary>
  /// An internal single thick solid line surrounded by a single thin solid line with a large gap between them.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThickThinLargeGap))]
  ThickThinLargeGap = 16,
  /// <summary>
  /// An internal single thin solid line surrounded by a single thick solid line surrounded by a single thin solid
  /// line with a large gap between all lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThinThickThinLargeGap))]
  ThinThickThinLargeGap = 17,
  /// <summary>
  /// A single wavy solid line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Wave))]
  SingleWavy = 18,
  /// <summary>
  /// Double wavy solid lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DoubleWave))]
  DoubleWavy = 19,
  /// <summary>
  /// A dash followed by a dot stroke, thus rendering a border similar to a barber pole.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.DashDotStroked))]
  DashDotStroked = 20,
  /// <summary>
  /// The border appears to have a 3-D embossed look.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThreeDEmboss))]
  Emboss3D = 21,
  /// <summary>
  /// The border appears to have a 3-D engraved look.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.ThreeDEngrave))]
  Engrave3D = 22,
  /// <summary>
  /// The border appears to be outset.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Outset))]
  Outset = 23,
  /// <summary>
  /// The border appears to be inset.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.BorderValues.Inset))]
  Inset = 24
}
