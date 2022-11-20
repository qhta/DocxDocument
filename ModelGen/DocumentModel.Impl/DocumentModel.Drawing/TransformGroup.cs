namespace DocumentModel.Drawing;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IChildOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtents))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IChildExtents))]
public class TransformGroup: ITransformGroup
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
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  public IChildOffset? ChildOffset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  public IChildExtents? ChildExtents
  {
    get;
    set;
  }
  
}
