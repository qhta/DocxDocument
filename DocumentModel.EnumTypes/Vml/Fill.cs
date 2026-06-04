namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Defines the Fill enumeration.
/// Used in types such as ArrayVariant, DefaultRunProperties, EffectContainer.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.FillValues))]
public enum Fill2
{
  /// <summary>
  ///   Centered Radial Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.GradientCenter))]
  GradientCenter,
  /// <summary>
  ///   Solid Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.Solid))]
  Solid,
  /// <summary>
  ///   Image Pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.Pattern))]
  Pattern,
  /// <summary>
  ///   Tiled Image.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.Tile))]
  Tile,
  /// <summary>
  ///   Stretch Image to Fit.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.Frame))]
  Frame,
  /// <summary>
  ///   Unscaled Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.GradientUnscaled))]
  GradientUnscaled,
  /// <summary>
  ///   Radial Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.GradientRadial))]
  GradientRadial,
  /// <summary>
  ///   Linear Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.Gradient))]
  Gradient,
  /// <summary>
  ///   Use Background Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.FillValues.Background))]
  Background
}
