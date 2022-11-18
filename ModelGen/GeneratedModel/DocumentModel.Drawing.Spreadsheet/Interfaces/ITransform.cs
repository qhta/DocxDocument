namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// 2D Transform for Graphic Frames.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IOffset))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtents))]
public interface ITransform // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rotation
  /// </summary>
  public int? Rotation { get ; set; }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public bool? HorizontalFlip { get ; set; }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public bool? VerticalFlip { get ; set; }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public IOffset? Offset { get ; set; }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public IExtents? Extents { get ; set; }
  
}
