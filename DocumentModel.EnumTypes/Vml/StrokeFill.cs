namespace DocumentModel.Vml;
/// <summary>
///   Defines the StrokeFillTypeValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.StrokeFillTypeValues))]
public enum StrokeFill
{
  /// <summary>
  ///   solid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeFillTypeValues.Solid))]
  Solid,
  /// <summary>
  ///   tile.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeFillTypeValues.Tile))]
  Tile,
  /// <summary>
  ///   pattern.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeFillTypeValues.Pattern))]
  Pattern,
  /// <summary>
  ///   frame.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.StrokeFillTypeValues.Frame))]
  Frame
}