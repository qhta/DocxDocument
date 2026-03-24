namespace DocumentModel.Vml;
/// <summary>
///   Shape Fill Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.FillTypeValues))]
public enum FillType
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  Mixed = -2,
  /// <summary>
  ///   Solid Fill.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillTypeValues.Solid))]
  Solid = 1,

  /// <summary>
  ///   Linear Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillTypeValues.Gradient))]
  Gradient,
  /// <summary>
  ///   Radial Gradient.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillTypeValues.GradientRadial))]
  GradientRadial,
  /// <summary>
  ///   Tiled Image.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.FillTypeValues.Tile))]
  Tile,
}