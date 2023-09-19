namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a BLIP should be tiled to fill the available space. This element defines a &quot;tile&quot; rectangle within the bounding box. The image is encompassed within the tile rectangle, and the tile rectangle is tiled across the bounding box to fill the entire area.
/// </summary>
public partial class Tile
{
  
  /// <summary>
  ///   Specifies additional horizontal offset after alignment.
  /// </summary>
  [SchemaAttr("tx")]
  public Int64? HorizontalOffset { get; set; }
  
  
  /// <summary>
  ///   Specifies additional vertical offset after alignment.
  /// </summary>
  [SchemaAttr("ty")]
  public Int64? VerticalOffset { get; set; }
  
  
  /// <summary>
  ///   Specifies the amount to horizontally scale the srcRect.
  /// </summary>
  [SchemaAttr("sx")]
  public Int32? HorizontalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the amount to vertically scale the srcRect.
  /// </summary>
  [SchemaAttr("sy")]
  public Int32? VerticalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the direction(s) in which to flip the source image while tiling. Images can be flipped horizontally, vertically, or in both directions to fill the entire region.
  /// </summary>
  [SchemaAttr("flip")]
  public DocumentModel.Drawings.TileFlipValues? Flip { get; set; }
  
  
  /// <summary>
  ///   Specifies where to align the first tile with respect to the shape. Alignment happens after the scaling, but before the additional offset.
  /// </summary>
  [SchemaAttr("algn")]
  public DocumentModel.Drawings.RectangleAlignmentValues? Alignment { get; set; }
  
}
