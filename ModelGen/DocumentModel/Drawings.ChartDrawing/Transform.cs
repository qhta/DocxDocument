namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Graphic Frame Transform.
/// </summary>
public partial class Transform
{
  
  /// <summary>
  ///   Rotation
  /// </summary>
  public Int32? Rotation { get; set; }
  
  
  /// <summary>
  ///   Horizontal Flip
  /// </summary>
  public Boolean? HorizontalFlip { get; set; }
  
  
  /// <summary>
  ///   Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip { get; set; }
  
  
  /// <summary>
  ///   Offset.
  /// </summary>
  public DocumentModel.Drawings.Offset? Offset { get; set; }
  
  
  /// <summary>
  ///   Extents.
  /// </summary>
  public DocumentModel.Drawings.Extents? Extents { get; set; }
  
}
