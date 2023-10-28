namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the Transform2D Class.
/// </summary>
public partial class Transform2D
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
  public DMD.Offset? Offset { get; set; }
  
  
  /// <summary>
  ///   Extents.
  /// </summary>
  public DMD.Extents? Extents { get; set; }
  
}
