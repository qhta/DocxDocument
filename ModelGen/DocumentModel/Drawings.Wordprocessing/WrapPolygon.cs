namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public partial class WrapPolygon
{
  
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  public Boolean? Edited { get; set; }
  
  
  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  public DocumentModel.Drawings.Wordprocessing.StartPoint? StartPoint { get; set; }
  
  public DM.ElementCollection<LineTo>? Items { get; set; }
  
}
