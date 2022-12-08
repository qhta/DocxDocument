namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Frame Transform.
/// </summary>
public class TransformImpl: ModelElementImpl, Transform
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.Transform?)_OpenXmlElement;
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
