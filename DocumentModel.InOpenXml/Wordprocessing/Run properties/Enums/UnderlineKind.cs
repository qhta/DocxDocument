namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the UnderlineValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.UnderlineValues))]
public enum UnderlineKind
{
  /// <summary>
  ///   Single Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Single))]
  Single,
  /// <summary>
  ///   Underline Non-Space Characters Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Words))]
  Words,
  /// <summary>
  ///   Double Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Double))]
  Double,
  /// <summary>
  ///   Thick Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Thick))]
  Thick,
  /// <summary>
  ///   Dotted Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Dotted))]
  Dotted,
  /// <summary>
  ///   Thick Dotted Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DottedHeavy))]
  DottedHeavy,
  /// <summary>
  ///   Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Dash))]
  Dash,
  /// <summary>
  ///   Thick Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashedHeavy))]
  DashedHeavy,
  /// <summary>
  ///   Long Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashLong))]
  DashLong,
  /// <summary>
  ///   Thick Long Dashed Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashLongHeavy))]
  DashLongHeavy,
  /// <summary>
  ///   Dash-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Thick Dash-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashDotHeavy))]
  DashDotHeavy,
  /// <summary>
  ///   Dash-Dot-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DotDotDash))]
  DotDotDash,
  /// <summary>
  ///   Thick Dash-Dot-Dot Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.DashDotDotHeavy))]
  DashDotDotHeavy,
  /// <summary>
  ///   Wave Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.Wave))]
  Wave,
  /// <summary>
  ///   Heavy Wave Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.WavyHeavy))]
  WavyHeavy,
  /// <summary>
  ///   Double Wave Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.WavyDouble))]
  WavyDouble,
  /// <summary>
  ///   No Underline.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.UnderlineValues.None))]
  None
}