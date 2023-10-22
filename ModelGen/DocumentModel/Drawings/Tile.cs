namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a BLIP should be tiled to fill the available space. This element defines a &quot;tile&quot; rectangle within the bounding box. The image is encompassed within the tile rectangle, and the tile rectangle is tiled across the bounding box to fill the entire area.
/// </summary>
public partial class Tile
{
  
  /// <summary>
  ///   Specifies additional horizontal offset after alignment.
  /// </summary>
  public Int64? HorizontalOffset { get; set; }
  
  
  /// <summary>
  ///   Specifies additional vertical offset after alignment.
  /// </summary>
  public Int64? VerticalOffset { get; set; }
  
  
  /// <summary>
  ///   Specifies the amount to horizontally scale the srcRect.
  /// </summary>
  public Int32? HorizontalRatio { get; set; }
  
  
  /// <summary>
  ///   Specifies the amount to vertically scale the srcRect.
  /// </summary>
  public Int32? VerticalRatio { get; set; }
  
}
