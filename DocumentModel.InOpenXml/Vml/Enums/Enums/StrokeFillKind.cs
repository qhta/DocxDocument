namespace DocumentModel.Vml;
/// <summary>
///   Defines the StrokeFillTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXV.StrokeFillTypeValues))]
public enum StrokeFillKind
{
  /// <summary>
  ///   solid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeFillTypeValues.Solid))]
  Solid,
  /// <summary>
  ///   tile.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeFillTypeValues.Tile))]
  Tile,
  /// <summary>
  ///   pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeFillTypeValues.Pattern))]
  Pattern,
  /// <summary>
  ///   frame.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXV.StrokeFillTypeValues.Frame))]
  Frame
}