namespace DocumentModel.Drawings;
/// <summary>
///   Tile Flip Mode
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TileFlipValues))]
public enum TileFlip
{
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TileFlipValues.None))]
  None,
  /// <summary>
  ///   Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TileFlipValues.Horizontal))]
  Horizontal,
  /// <summary>
  ///   Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TileFlipValues.Vertical))]
  Vertical,
  /// <summary>
  ///   Horizontal and Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TileFlipValues.HorizontalAndVertical))]
  HorizontalAndVertical
}