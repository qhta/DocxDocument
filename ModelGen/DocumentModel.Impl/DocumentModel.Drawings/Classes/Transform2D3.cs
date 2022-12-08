namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public class Transform2D3Impl: ModelElementImpl, Transform2D3
{
  public DocumentFormat.OpenXml.Drawing.Transform2D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Transform2D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Int32? Rotation
  {
    get;
    set;
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public Boolean? HorizontalFlip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public Point2DType? Offset
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public PositiveSize2DType? Extents
  {
    get;
    set;
  }
  
}
