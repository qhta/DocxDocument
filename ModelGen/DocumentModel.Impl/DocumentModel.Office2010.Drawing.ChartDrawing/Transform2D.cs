namespace DocumentModel.Office2010.Drawing.ChartDrawing;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtents))]
public class Transform2D: ITransform2D
{
  /// <summary>
  /// Rotation
  /// </summary>
  public int? Rotation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public bool? HorizontalFlip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public bool? VerticalFlip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public IOffset? Offset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public IExtents? Extents
  {
    get;
    set;
  }
  
}
