namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Fill Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.FillValues))]
public enum FillKind
{
  /// <summary>
  ///   Centered Radial Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.GradientCenter))]
  GradientCenter,
  /// <summary>
  ///   Solid Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.Solid))]
  Solid,
  /// <summary>
  ///   Image Pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.Pattern))]
  Pattern,
  /// <summary>
  ///   Tiled Image.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.Tile))]
  Tile,
  /// <summary>
  ///   Stretch Image to Fit.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.Frame))]
  Frame,
  /// <summary>
  ///   Unscaled Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.GradientUnscaled))]
  GradientUnscaled,
  /// <summary>
  ///   Radial Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.GradientRadial))]
  GradientRadial,
  /// <summary>
  ///   Linear Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.Gradient))]
  Gradient,
  /// <summary>
  ///   Use Background Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.FillValues.Background))]
  Background
}