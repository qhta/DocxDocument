namespace DocumentModel.Drawings;
/// <summary>
///   Text Underline Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues))]
public enum TextUnderline
{
  /// <summary>
  ///   Text Underline Enum ( None ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.None))]
  None = 1,

  /// <summary>
  ///   Text Underline Enum ( Words ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Words))]
  Words,
  /// <summary>
  ///   Text Underline Enum ( Single ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Single))]
  Single,
  /// <summary>
  ///   Text Underline Enum ( Double ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Double))]
  Double,
  /// <summary>
  ///   Text Underline Enum ( Heavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Heavy))]
  Heavy,
  /// <summary>
  ///   Text Underline Enum ( Dotted ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Dotted))]
  Dotted,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dotted  ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.HeavyDotted))]
  HeavyDotted,
  /// <summary>
  ///   Text Underline Enum ( Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Dash))]
  Dash,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DashHeavy))]
  DashHeavy,
  /// <summary>
  ///   Text Underline Enum ( Long Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DashLong))]
  DashLong,
  /// <summary>
  ///   Text Underline Enum ( Heavy Long Dashed ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DashLongHeavy))]
  DashLongHeavy,
  /// <summary>
  ///   Text Underline Enum ( Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DotDash))]
  DotDash,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DotDashHeavy))]
  DotDashHeavy,
  /// <summary>
  ///   Text Underline Enum ( Dot Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DotDotDash))]
  DotDotDash,
  /// <summary>
  ///   Text Underline Enum ( Heavy Dot Dot Dash ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.DotDotDashHeavy))]
  DotDotDashHeavy,
  /// <summary>
  ///   Text Underline Enum ( Wavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.Wavy))]
  Wavy,
  /// <summary>
  ///   Text Underline Enum ( Heavy Wavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.WavyHeavy))]
  WavyHeavy,
  /// <summary>
  ///   Text Underline Enum ( Double Wavy ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextUnderlineValues.WavyDouble))]
  WavyDouble
}
