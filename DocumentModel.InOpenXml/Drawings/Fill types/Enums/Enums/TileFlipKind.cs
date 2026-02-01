namespace DocumentModel.Drawings;
/// <summary>
///   Tile Flip Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TileFlipValues))]
public enum TileFlipKind
{
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TileFlipValues.None))]
  None,
  /// <summary>
  ///   Horizontal.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TileFlipValues.Horizontal))]
  Horizontal,
  /// <summary>
  ///   Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TileFlipValues.Vertical))]
  Vertical,
  /// <summary>
  ///   Horizontal and Vertical.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TileFlipValues.HorizontalAndVertical))]
  HorizontalAndVertical
}