namespace DocumentModel.Drawing.ChartDrawing;

/// <summary>
/// Graphic Frame Transform.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtents))]
public class Transform: ITransform
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
