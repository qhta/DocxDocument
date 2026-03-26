namespace DocumentModel.Drawings;
/// <summary>
///   Text Underline Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextUnderlineValues))]
public enum TextUnderline
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Text Underline Enum ( None ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.None))]
  None = 1,

  /// <summary>
  ///   Text Underline Enum ( Words ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Words))]
  Words,
  /// <summary>
  ///   Text Underline Enum ( Single ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Single))]
  Single,
  /// <summary>
  ///   Text Underline Enum ( Double ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Double))]
  Double,
  /// <summary>
  ///   Text Underline Enum ( Heavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Heavy))]
  Heavy,
  /// <summary>
  ///   Text Underline Enum ( Dotted ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Dotted))]
  Dotted,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dotted  ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.HeavyDotted))]
  HeavyDotted,
  /// <summary>
  ///   Text Underline Enum ( Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Dash))]
  Dash,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DashHeavy))]
  DashHeavy,
  /// <summary>
  ///   Text Underline Enum ( Long Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DashLong))]
  DashLong,
  /// <summary>
  ///   Text Underline Enum ( Heavy Long Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DashLongHeavy))]
  DashLongHeavy,
  /// <summary>
  ///   Text Underline Enum ( Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DotDashHeavy))]
  DotDashHeavy,
  /// <summary>
  ///   Text Underline Enum ( Dot Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DotDotDash))]
  DotDotDash,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dot Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.DotDotDashHeavy))]
  DotDotDashHeavy,
  /// <summary>
  ///   Text Underline Enum ( Wavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.Wavy))]
  Wavy,
  /// <summary>
  ///   Text Underline Enum ( Heavy Wavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.WavyHeavy))]
  WavyHeavy,
  /// <summary>
  ///   Text Underline Enum ( Double Wavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextUnderlineValues.WavyDouble))]
  WavyDouble
}