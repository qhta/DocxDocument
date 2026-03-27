namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of underline to apply.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdunderline?view=office-pia` for Office interop details.
/// </remarks>
[OpenXmlEnumType(typeof(DXW.UnderlineValues))]
public enum UnderlineType
{
  /// <summary>
  /// No underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.None))]
  None = 0,
  /// <summary>
  /// A single line. default.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Single))]
  Single = 1,
  /// <summary>
  /// Underline individual words only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Words))]
  Words = 2,
  /// <summary>
  /// A double line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Double))]
  Double = 3,
  /// <summary>
  /// Dots.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Dotted))] 
  Dotted = 4,
  /// <summary>
  /// A single thick line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Thick))]
  Thick = 6,
  /// <summary>
  /// Dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Dash))]
  Dash = 7,
  /// <summary>
  /// Alternating dots and dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DotDash))]
  DotDash = 9,
  /// <summary>
  /// An alternating dot-dot-dash pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DotDotDash))]
  DotDotDash = 10,
  /// <summary>
  /// A single wavy line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Wave))] 
  Wave = 11,
  /// <summary>
  /// Heavy dots.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DottedHeavy))]
  DottedHeavy = 20,
  /// <summary>
  /// Heavy dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashedHeavy))] 
  DashedHeavy = 23,
  /// <summary>
  /// Alternating heavy dots and heavy dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashDotHeavy))] 
  DashDotHeavy = 25,
  /// <summary>
  /// An alternating heavy dot-dot-dash pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashDotDotHeavy))]
  DashDotDotHeavy = 26,
  /// <summary>
  /// A heavy wavy line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.WavyHeavy))]
  WavyHeavy = 27,
  /// <summary>
  /// Long dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashLong))]
  DashLong = 39,
  /// <summary>
  /// A double wavy line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.WavyDouble))]
  WavyDouble = 43,
  /// <summary>
  /// Long heavy dashes.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashLongHeavy))]
  DashLongHeavy = 55
}
