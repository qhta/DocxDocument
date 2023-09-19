namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public partial class WrapPolygon
{
  
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  [SchemaAttr("edited")]
  public Boolean? Edited { get; set; }
  
  
  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.Point2DType? StartPoint { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Drawings.Wordprocessing.Point2DType>? Items { get; set; }
  
}
