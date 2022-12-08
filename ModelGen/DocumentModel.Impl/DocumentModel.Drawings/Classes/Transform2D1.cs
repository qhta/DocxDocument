namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Transform2D Class.
/// </summary>
public class Transform2D1Impl: ModelElementImpl, Transform2D1
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.Transform2D?)_OpenXmlElement;
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
