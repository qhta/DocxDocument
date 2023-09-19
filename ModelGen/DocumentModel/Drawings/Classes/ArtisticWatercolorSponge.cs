namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticWatercolorSponge Class.
/// </summary>
public partial class ArtisticWatercolorSponge
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("brushSize")]
  public Int32? BrushSize { get; set; }
  
}
