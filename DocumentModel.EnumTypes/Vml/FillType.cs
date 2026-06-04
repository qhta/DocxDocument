namespace DocumentModel.Vml;
/// <summary>
///   Shape Fill Type
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.FillTypeValues))]
public enum FillType
{
  /// <summary>
  ///   Solid Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillTypeValues.Solid))]
  Solid = 1,

  /// <summary>
  ///   Linear Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillTypeValues.Gradient))]
  Gradient,
  /// <summary>
  ///   Radial Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillTypeValues.GradientRadial))]
  GradientRadial,
  /// <summary>
  ///   Tiled Image.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.FillTypeValues.Tile))]
  Tile,
}