namespace DocumentModel.Drawings;

/// <summary>
/// 2D Transform for Grouped Objects.
/// </summary>
public class TransformGroupImpl: ModelElementImpl, TransformGroup
{
  public DocumentFormat.OpenXml.Drawing.TransformGroup? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TransformGroup?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TransformGroupImpl(): base() {}
  
  public TransformGroupImpl(DocumentFormat.OpenXml.Drawing.TransformGroup openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Int32? Rotation
  {
    get => (System.Int32?)OpenXmlElement?.Rotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotation = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Flip
  /// </summary>
  public Boolean? HorizontalFlip
  {
    get => (System.Boolean?)OpenXmlElement?.HorizontalFlip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalFlip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip
  {
    get => (System.Boolean?)OpenXmlElement?.VerticalFlip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalFlip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Offset.
  /// </summary>
  public DocumentModel.Drawings.Point2DType? Offset
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Extents.
  /// </summary>
  public DocumentModel.Drawings.PositiveSize2DType? Extents
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Child Offset.
  /// </summary>
  public DocumentModel.Drawings.Point2DType? ChildOffset
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Child Extents.
  /// </summary>
  public DocumentModel.Drawings.PositiveSize2DType? ChildExtents
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
